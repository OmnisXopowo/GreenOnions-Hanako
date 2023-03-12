﻿using GreenOnions.BotMain;
using GreenOnions.BotMain.Knife;
using GreenOnions.BotMain.MiraiApiHttp;
using GreenOnions.BotMain.OneBot;
using GreenOnions.Utility;
using GreenOnions.Utility.Helper;

namespace GreenOnions.BotManagerWindows
{
	public partial class FrmMain : Form
	{
		private WebBrowserForm? webBrowserForm;
		private bool _connecting;
		private MiraiClient? _miraiClient;

		public FrmMain()
		{
			InitializeComponent();

			try
            {
                webBrowserForm = new WebBrowserForm();
                EventHelper.GetDocumentByBrowserEvent += webBrowserForm.GetDocument;
            }
			catch (Exception ex)
			{
				LogHelper.WriteErrorLog("初始化浏览器组件失败！请检查 VC++2015-2019 是否已安装", ex);
				MessageBox.Show("初始化浏览器组件失败！请检查 VC++2015-2019 是否已安装");
			}

			#region -- 读取配置 --
			try
			{
				if (!File.Exists("config.json"))
				{
					MessageBox.Show("初次使用本机器人，请先配置相关参数。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new FrmAppSetting().ShowDialog();
				}

				txbQQ.Text = BotInfo.Config.QQId.ToString();
				txbIP.Text = BotInfo.Config.IP;
				txbPort.Text = BotInfo.Config.Port.ToString();
				txbVerifyKey.Text = BotInfo.Config.VerifyKey;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"读取配置发生异常，{ex.Message}，请删除应用目录下的config.json和cache.json文件后重启应用。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			#endregion -- 读取配置 --
		}

		protected override async void OnShown(EventArgs e)
		{
			base.OnShown(e);

			int iLoadCount = 0;
			await Task.Run(() => iLoadCount = PluginManager.Load());
			btnPlugins.Text = $"插件列表({iLoadCount})";

			btnConnectToMiraiApiHttp.Enabled = true;
            btnConnectToOneBot.Enabled = true;

            //自动连接到机器人平台
            if (BotInfo.Config.AutoConnectEnabled)
            {
                Task.Delay(BotInfo.Config.AutoConnectDelay * 1000).Wait();
                WorkingTimeRecorder.DoWork = true;
                ConnectToPlatform(BotInfo.Config.AutoConnectProtocol);
            }

#if DEBUG
			btnConnectToKnife.Visible = true;
#endif
        }

		protected override void OnSizeChanged(EventArgs e)
		{
			base.OnSizeChanged(e);
			if (WindowState == FormWindowState.Minimized)
			{
				if (chkMinimizeToTray.Checked)
				{
					Hide();
					ShowInTaskbar = false;
					notifyIcon.Visible = true;
				}
			}
		}

		private async void ConnectToPlatform(int platform)
		{
			WorkingTimeRecorder.DoWork = true;
			if (_connecting)
				return;

			_connecting = true;
			if (!CheckInfo())
				return;

			try
			{
				_miraiClient = platform switch
				{
					0 => new MiraiApiHttpClient((bConnect, nickNameOrErrorMessage) => Connecting(bConnect, BotInfo.Config.QQId, BotInfo.Config.IP, BotInfo.Config.Port, BotInfo.Config.VerifyKey, nickNameOrErrorMessage, 0, "mirai-api-http")),
					1 => new OneBotClient((bConnect, nickNameOrErrorMessage) => Connecting(bConnect, BotInfo.Config.QQId, BotInfo.Config.IP, BotInfo.Config.Port, BotInfo.Config.VerifyKey, nickNameOrErrorMessage, 1, "OneBot")),
                    2 => new KnifeClient((bConnect, nickNameOrErrorMessage) => Connecting(bConnect, BotInfo.Config.QQId, BotInfo.Config.IP, BotInfo.Config.Port, BotInfo.Config.VerifyKey, nickNameOrErrorMessage, 1, "Knife")),
                    _ => throw new NotImplementedException(),
				};
				await _miraiClient.Connect(BotInfo.Config.QQId, BotInfo.Config.IP, BotInfo.Config.Port, BotInfo.Config.VerifyKey);
			}
			catch (Exception ex)
			{
				MessageBox.Show($"连接失败：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				_connecting = false;
			}
		}

		private void btnDeconnect_Click(object? sender, EventArgs e)
		{
			WorkingTimeRecorder.DoWork = false;
			Disconnect();
		}

		private async void Disconnect()
		{
			if (_miraiClient is not null)
                await _miraiClient.Disconnect();

			btnConnectToMiraiApiHttp.Click -= btnDeconnect_Click;
			btnConnectToMiraiApiHttp.Click += btnConnectToMiraiApiHttp_Click;

			btnConnectToOneBot.Click -= btnDeconnect_Click;
			btnConnectToOneBot.Click += btnConnectToOneBot_Click;
		}

		private void btnConnectToMiraiApiHttp_Click(object? sender, EventArgs e)
		{
			ConnectToPlatform(0);
		}

		private void btnConnectToOneBot_Click(object? sender, EventArgs e)
		{
			ConnectToPlatform(1);
		}

        private void btnConnectToKnife_Click(object sender, EventArgs e)
        {
            ConnectToPlatform(2);
        }

        private void btnBotSettings_Click(object sender, EventArgs e)
		{
			btnBotSettings.Enabled = false;
            FrmAppSetting frmSetting = new FrmAppSetting();
			frmSetting.FormClosed += (_, _) => btnBotSettings.Enabled = true;
			frmSetting.Show();
		}
		
		private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			Visible = true;
			ShowInTaskbar = true;
			WindowState = FormWindowState.Normal;
			notifyIcon.Visible = false;
		}

		private void Connecting(bool bConnect, long qqId, string ip, ushort port, string verifyKey, string nickNameOrErrorMessage, int platform, string protocolName)
		{
			Invoke(() =>
			{
				if (bConnect)
				{
					lblState.Text = $"连接状态: 已连接到{protocolName}, 登录昵称:{nickNameOrErrorMessage}";
					lblState.ForeColor = Color.Black;

					btnConnectToMiraiApiHttp.Text = "断开连接";
					btnConnectToMiraiApiHttp.Click -= btnConnectToMiraiApiHttp_Click;
					btnConnectToMiraiApiHttp.Click += btnDeconnect_Click;

					btnConnectToOneBot.Text = "断开连接";
					btnConnectToOneBot.Click -= btnConnectToOneBot_Click;
					btnConnectToOneBot.Click += btnDeconnect_Click;

					notifyIcon.Text = $"葱葱机器人:{nickNameOrErrorMessage}";

					BotInfo.Config.QQId = qqId;
					BotInfo.Config.IP = ip;
					BotInfo.Config.Port = port;
					BotInfo.Config.VerifyKey = verifyKey;

					BotInfo.SaveConfigFile();

					WorkingTimeRecorder.StartRecord(platform, ConnectToPlatform, Disconnect);

					webBrowserForm?.Show();
				}
				else if (nickNameOrErrorMessage is null)  //连接失败且没有异常
				{
					MessageBox.Show($"连接失败，请检查{protocolName}是否已经正常启动并已配置IP端口相关参数, 以及机器人QQ是否成功登录。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
				else  //发生异常或主动断开连接
				{
					btnConnectToMiraiApiHttp.Text = "连接到mirai-api-http";
					btnConnectToOneBot.Text = "连接到OneBot";
					lblState.Text = $"连接状态: 未连接到机器人平台";
					lblState.ForeColor = Color.Red;
					notifyIcon.Text = $"葱葱机器人";
					if (nickNameOrErrorMessage.Length > 0)  //发生异常
						MessageBox.Show("连接失败，" + nickNameOrErrorMessage, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			});
		}

		private bool CheckInfo()
		{
			if (BotInfo.IsLogin)
			{
				return false;
			}
			if (string.IsNullOrEmpty(txbQQ.Text))
			{
				MessageBox.Show("请先输入机器人QQ号。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			if (string.IsNullOrEmpty(txbIP.Text))
			{
				MessageBox.Show("请先输入机器人平台 IP。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			if (string.IsNullOrEmpty(txbPort.Text))
			{
				MessageBox.Show("请先输入机器人平台端口号。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return false;
			}
			BotInfo.Config.QQId = Convert.ToInt64(txbQQ.Text);
			BotInfo.Config.IP = txbIP.Text;
			BotInfo.Config.Port = Convert.ToUInt16(txbPort.Text);
			BotInfo.Config.VerifyKey = txbVerifyKey.Text;
			return true;
		}

		private void btnPlugins_Click(object sender, EventArgs e)
		{
			new FrmPlugins().ShowDialog();
		}
    }
}