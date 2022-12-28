﻿using System.Collections.Generic;

namespace GreenOnions.Utility
{
    public static class Constants
    {
        public static Dictionary<string, string> GoogleLanguages { get; } = new()
        {
            {"自动" , "Auto"},
            {"旁遮普文" , "Punjabi"},
            {"葡萄牙文" , "Portuguese"},
            {"波兰文" , "Polish"},
            {"波斯文" , "Persian"},
            {"普什图文" , "Pashto"},
            {"挪威文" , "Norwegian"},
            {"尼泊尔文" , "Nepali"},
            {"缅甸文" , "MyanmarBurmese"},
            {"蒙古文" , "Mongolian"},
            {"马拉地文" , "Marathi"},
            {"毛利文" , "Maori"},
            {"罗马尼亚文" , "Romanian"},
            {"马耳他文" , "Maltese"},
            {"马来文" , "Malay"},
            {"马尔加什文" , "Malagasy"},
            {"马其顿文" , "Macedonian"},
            {"卢森堡文" , "Luxembourgish"},
            {"立陶宛文" , "Lithuanian"},
            {"拉脱维亚文" , "Latvian"},
            {"拉丁文" , "Latin"},
            {"老挝文" , "Lao"},
            {"吉尔吉斯文" , "Kyrgyz"},
            {"库尔德文" , "KurdishKurmanji"},
            {"韩文" , "Korean"},
            {"韩国文" , "Korean"},
            {"马拉雅拉姆文" , "Malayalam"},
            {"高棉文" , "Khmer"},
            {"俄文" , "Russian"},
            {"俄罗斯文" , "Russian"},
            {"苏格兰盖尔文" , "ScotsGaelic"},
            {"意第绪文" , "Yiddish"},
            {"科萨文" , "Xhosa"},
            {"南非科萨文" , "Xhosa"},
            {"威尔士文" , "Welsh"},
            {"越南文" , "Vietnamese"},
            {"乌兹别克文" , "Uzbek"},
            {"乌尔都文" , "Urdu"},
            {"乌克兰文" , "Ukrainian"},
            {"土耳其文" , "Turkish"},
            {"泰文" , "Thai"},
            {"泰国文" , "Thai"},
            {"泰卢固文" , "Telugu"},
            {"泰米尔文" , "Tamil"},
            {"萨摩亚文" , "Samoan"},
            {"塔吉克文" , "Tajik"},
            {"斯瓦希里文" , "Swahili"},
            {"印尼巽他文" , "Sundanese"},
            {"西班牙文" , "Spanish"},
            {"索马里文" , "Somali"},
            {"斯洛文尼亚文" , "Slovenian"},
            {"斯洛伐克文" , "Slovak"},
            {"僧伽罗文" , "Sinhala"},
            {"信德文" , "Sindhi"},
            {"修纳文" , "Shona"},
            {"塞索托文" , "Sesotho"},
            {"塞尔维亚文" , "Serbian"},
            {"瑞典文" , "Swedish"},
            {"哈萨克文" , "Kazakh"},
            {"卡纳达文" , "Kannada"},
            {"印尼爪哇文" , "Javanese"},
            {"约鲁巴文" , "Yoruba"},
            {"捷克文" , "Czech"},
            {"克罗地亚文" , "Croatian"},
            {"科西嘉文" , "Corsican"},
            {"繁体中文" , "ChineseTraditional"},
            {"简体中文" , "ChineseSimplified"},
            {"齐切瓦文" , "Chichewa"},
            {"宿务文" , "Cebuano"},
            {"加泰罗尼亚文" , "Catalan"},
            {"保加利亚文" , "Bulgarian"},
            {"波斯尼亚文" , "Bosnian"},
            {"孟加拉文" , "Bengali"},
            {"白俄罗斯文" , "Belarusian"},
            {"巴斯克文" , "Basque"},
            {"阿塞拜疆文" , "Azerbaijani"},
            {"亚美尼亚文" , "Armenian"},
            {"阿拉伯文" , "Arabic"},
            {"阿姆哈拉文" , "Amharic"},
            {"阿尔巴尼亚文" , "Albanian"},
            {"布尔文" , "Afrikaans"},
            {"南非文" , "Afrikaans"},
            {"布尔文(南非荷兰文)" , "Afrikaans"},
            {"南非荷兰文" , "Afrikaans"},
            {"荷兰文" , "Dutch"},
            {"英文" , "English"},
            {"丹麦文" , "Danish"},
            {"爱沙尼亚文" , "Estonian"},
            {"日文" , "Japanese"},
            {"日本文" , "Japanese"},
            {"意大利文" , "Italian"},
            {"爱尔兰文" , "Irish"},
            {"印度尼西亚文" , "Indonesian"},
            {"伊博文" , "Igbo"},
            {"冰岛文" , "Icelandic"},
            {"匈牙利文" , "Hungarian"},
            {"世界文" , "Esperanto"},
            {"印地文" , "Hindi"},
            {"希伯来文" , "Hebrew"},
            {"夏威夷文" , "Hawaiian"},
            {"苗文" , "Hmong"},
            {"苗族文" , "Hmong"},
            {"海地克里奥尔文" , "HaitianCreole"},
            {"菲律宾文" , "Filipino"},
            {"豪萨文" , "Hausa"},
            {"法文" , "French"},
            {"法国文" , "French"},
            {"弗里西文" , "Frisian"},
            {"弗里斯文" , "Frisian"},
            {"弗里斯兰文" , "Frisian"},
            {"芬兰文" , "Finnish"},
            {"格鲁吉亚文" , "Georgian"},
            {"德文" , "German"},
            {"德国文" , "German"},
            {"希腊文" , "Greek"},
            {"古吉拉特文" , "Gujarati"},
            {"加利西亚文" , "Galician"},
            {"祖鲁文" , "Zulu"},
            {"南非祖鲁文" , "Zulu"},
        };

        public static Dictionary<string, string> YouDaoWebLanguages { get; } = new()
        {
            {"中文" , "ZH_CN"},
            {"英文" , "EN"},
            //{"日文" , "JA"},
            //{"韩文" , "KO"},
            //{"法文" , "FR"},
            //{"德文" , "DE"},
            //{"西班牙文" , "ES"},
            //{"葡萄牙文" , "PT"},
            //{"意大利文" , "IT"},
            //{"越南文" , "VI"},
            //{"印尼文" , "ID"},
            //{"阿拉伯文" , "AR"},
            //{"荷兰文" , "NL"},
            //{"泰文" , "TH"},
        };

        public static Dictionary<string, string> YouDaoLanguages { get; } = new()
        {
            { "自动识别", "auto" },
            { "中文", "zh-CHS" },
            { "繁体中文", "zh-CHT" },
            { "英文", "en" },
            { "日文", "ja" },
            { "韩文", "ko" },
            { "法文", "fr" },
            { "西班牙文", "es" },
            { "葡萄牙文", "pt" },
            { "意大利文", "it" },
            { "俄文", "ru" },
            { "越南文", "vi" },
            { "德文", "de" },
            { "阿拉伯文", "ar" },
            { "印尼文", "id" },
            { "南非荷兰文", "af" },
            { "波斯尼亚文", "bs" },
            { "保加利亚文", "bg" },
            { "粤文", "yue" },
            { "加泰隆文", "ca" },
            { "克罗地亚文", "hr" },
            { "捷克文", "cs" },
            { "丹麦文", "da" },
            { "荷兰文", "nl" },
            { "爱沙尼亚文", "et" },
            { "斐济文", "fj" },
            { "芬兰文", "fi" },
            { "希腊文", "el" },
            { "海地克里奥尔文", "ht" },
            { "希伯来文", "he" },
            { "印地文", "hi" },
            { "白苗文", "mww" },
            { "匈牙利文", "hu" },
            { "斯瓦希里文", "sw" },
            { "克林贡文", "tlh" },
            { "拉脱维亚文", "lv" },
            { "立陶宛文", "lt" },
            { "马来文", "ms" },
            { "马耳他文", "mt" },
            { "挪威文", "no" },
            { "波斯文", "fa" },
            { "波兰文", "pl" },
            { "克雷塔罗奥托米文", "otq" },
            { "罗马尼亚文", "ro" },
            { "塞尔维亚文(西里尔文)", "sr-Cyrl" },
            { "塞尔维亚文(拉丁文)", "sr-Latn" },
            { "斯洛伐克文", "sk" },
            { "斯洛文尼亚文", "sl" },
            { "瑞典文", "sv" },
            { "塔希提文", "ty" },
            { "泰文", "th" },
            { "汤加文", "to" },
            { "土耳其文", "tr" },
            { "乌克兰文", "uk" },
            { "乌尔都文", "ur" },
            { "威尔士文", "cy" },
            { "尤卡坦玛雅文", "yua" },
            { "阿尔巴尼亚文", "sq" },
            { "阿姆哈拉文", "am" },
            { "亚美尼亚文", "hy" },
            { "阿塞拜疆文", "az" },
            { "孟加拉文", "bn" },
            { "巴斯克文", "eu" },
            { "白俄罗斯文", "be" },
            { "宿务文", "ceb" },
            { "科西嘉文", "co" },
            { "世界文", "eo" },
            { "菲律宾文", "tl" },
            { "弗里西文", "fy" },
            { "加利西亚文", "gl" },
            { "格鲁吉亚文", "ka" },
            { "古吉拉特文", "gu" },
            { "豪萨文", "ha" },
            { "夏威夷文", "haw" },
            { "冰岛文", "is" },
            { "伊博文", "ig" },
            { "爱尔兰文", "ga" },
            { "爪哇文", "jw" },
            { "卡纳达文", "kn" },
            { "哈萨克文", "kk" },
            { "高棉文", "km" },
            { "库尔德文", "ku" },
            { "柯尔克孜文", "ky" },
            { "老挝文", "lo" },
            { "拉丁文", "la" },
            { "卢森堡文", "lb" },
            { "马其顿文", "mk" },
            { "马尔加什文", "mg" },
            { "马拉雅拉姆文", "ml" },
            { "毛利文", "mi" },
            { "马拉地文", "mr" },
            { "蒙古文", "mn" },
            { "缅甸文", "my" },
            { "尼泊尔文", "ne" },
            { "齐切瓦文", "ny" },
            { "普什图文", "ps" },
            { "旁遮普文", "pa" },
            { "萨摩亚文", "sm" },
            { "苏格兰盖尔文", "gd" },
            { "塞索托文", "st" },
            { "修纳文", "sn" },
            { "信德文", "sd" },
            { "僧伽罗文", "si" },
            { "索马里文", "so" },
            { "巽他文", "su" },
            { "塔吉克文", "tg" },
            { "泰米尔文", "ta" },
            { "泰卢固文", "te" },
            { "乌兹别克文", "uz" },
            { "南非科萨文", "xh" },
            { "意第绪文", "yi" },
            { "约鲁巴文", "yo" },
            { "南非祖鲁文", "zu" },
        };

        public static Dictionary<string, string> BaiduLanguages { get; } = new()
        {
            { "自动检测", "auto" },
            { "中文", "zh" },
            { "英文", "en" },
            { "粤文", "yue" },
            { "文言文", "wyw" },
            { "日文", "jp" },
            { "韩文", "kor" },
            { "法文", "fra" },
            { "西班牙文", "spa" },
            { "泰文", "th" },
            { "阿拉伯文", "ara" },
            { "俄文", "ru" },
            { "葡萄牙文", "pt" },
            { "德文", "de" },
            { "意大利文", "it" },
            { "希腊文", "el" },
            { "荷兰文", "nl" },
            { "波兰文", "	pl" },
            { "保加利亚文", "bul" },
            { "爱沙尼亚文", "est" },
            { "丹麦文", "dan" },
            { "芬兰文", "fin" },
            { "捷克文", "cs" },
            { "罗马尼亚文", "rom" },
            { "斯洛文尼亚文", "slo" },
            { "瑞典文", "swe" },
            { "匈牙利文", "hu" },
            { "繁体中文", "cht" },
            { "越南文", "vie" },
        };
    }
}
