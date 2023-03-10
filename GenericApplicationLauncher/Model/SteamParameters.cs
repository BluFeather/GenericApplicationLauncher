using System.Collections.Generic;

namespace GenericApplicationLauncher.Model
{
    public static class SteamParameters
    {
        public static Dictionary<string, HashSet<string>> Presets { get; } = new Dictionary<string, HashSet<string>>()
        {
            {"(Clear All)", new HashSet<string>(){}},
            {"Team A Preset One", new HashSet<string>(){}},
            {"Team A Preset Two", new HashSet<string>(){}},
            {"Team B Preset One", new HashSet<string>(){}},
            {"Team B Preset Two", new HashSet<string>(){}},
            {"Team C Preset One", new HashSet<string>(){}},
            {"Team C Preset Two", new HashSet<string>(){}},
            {"Temporary Preset", new HashSet<string>(){}},
        };

        public static Dictionary<string, string> SingleSteamParameters { get; } = new Dictionary<string, string>()
        {
            //{"applaunch <appID> [launch parameters]", "-applaunch <appID> [launch parameters]"},
            {"cafeapplaunch", "-cafeapplaunch"},
            {"clearbeta", "-clearbeta"},
            {"complete_install_via_http", "-complete_install_via_http"},
            {"console", "-console"},
            {"ccsyntax", "-ccsyntax"},
            {"debug_steamapi", "-debug_steamapi"},
            {"dev", "-dev"},
            {"fs_log", "-fs_log"},
            {"fs_target", "-fs_target"},
            {"fs_logbins", "-fs_logbins"},
            {"forceservice", "-forceservice"},
            {"gameoverlayinject", "-gameoverlayinject"},
            //{"install <path>", "-install <path>"},
            {"installer_test", "-installer_test"},
            //{"language <language>", "-language <language>"},
            //{"login <[username]|anonymous> [password]", "-login <[username]|anonymous> [password]"},
            {"lognetapi", "-lognetapi"},
            {"log_voice", "-log_voice"},
            {"noasync", "-noasync"},
            {"nocache", "-nocache"},
            {"nofriendsui", "-nofriendsui"},
            {"noverifyfiles", "-noverifyfiles"},
            {"no-browser", "-no-browser"},
            {"no-dwrite", "-no-dwrite"},
            {"oldbigpicture", "-oldbigpicture"},
            //{"script <file name>", "-script <file name>"},
            {"shutdown", "-shutdown"},
            {"silent", "-silent"},
            {"single_core", "-single_core"},
            {"tcp", "-tcp"},
            {"voice_quality", "-voice_quality"},
            {"voicerelay", "-voicerelay"},
            {"tenfoot", "-tenfoot"},
            {"gamepadui", "-gamepadui"},
        };

        public static Dictionary<string, string> LocaleOptions { get; } = new Dictionary<string, string>()
        {
            {"(Locale Options)", ""},
            {"Arabic *", "-language arabic"},
            {"Bulgarian", "-language bulgarian"},
            {"Chinese (Simplified)", "-language schinese"},
            {"Chinese (Traditional)", "-language tchinese"},
            {"Czech", "-language czech"},
            {"Danish", "-language danish"},
            {"Dutch", "-language dutch"},
            {"English", "-language english"},
            {"Finnish", "-language finnish"},
            {"French", "-language french"},
            {"German", "-language german"},
            {"Greek", "-language greek"},
            {"Hungarian", "-language hungarian"},
            {"Italian", "-language italian"},
            {"Japanese", "-language japanese"},
            {"Korean", "-language koreana"},
            {"Norwegian", "-language norwegian"},
            {"Polish", "-language polish"},
            {"Portuguese", "-language portuguese"},
            {"Portuguese-Brazil", "-language brazilian"},
            {"Romanian", "-language romanian"},
            {"Russian", "-language russian"},
            {"Spanish-Spain", "-language spanish"},
            {"Spanish-Latin America", "-language latam"},
            {"Swedish", "-language swedish"},
            {"Thai", "-language thai"},
            {"Turkish", "-language turkish"},
            {"Ukrainian", "-language ukrainian"},
            {"Vietnamese", "-language vietnamese"},
        };

        public static Dictionary<string, string> GenericOptionsOne { get; } = new Dictionary<string, string>()
        {
            {"(Generic Options 1)", "" },
            {"Option 1", "-opt1"},
            {"Option 2", "-opt2"},
            {"Option 3", "-opt3"},
            {"Option 4", "-opt4"},
            {"Option 5", "-opt5"},
            {"Option 6", "-opt6"},
            {"Option 7", "-opt7"},
            {"Option 8", "-opt8"},
            {"Option 9", "-opt9"},
            {"Option 10", "-opt10"},
            {"Option 11", "-opt11"},
            {"Option 12", "-opt12"},
            {"Option 13", "-opt13"},
            {"Option 14", "-opt14"},
            {"Option 15", "-opt15"},
        };

        public static Dictionary<string, string> GenericOptionsTwo { get; } = new Dictionary<string, string>()
        {
            {"(Generic Options 2)", "" },
            {"Option A", "-typea"},
            {"Option B", "-typeb"},
            {"Option C", "-typec"},
            {"Option D", "-typed"},
            {"Option E", "-typee"},
            {"Option F", "-typef"},
        };

        public static Dictionary<string, string> GenericOptionsThree { get; } = new Dictionary<string, string>()
        {
            {"(Generic Options 3)", "" },
            {"Condition One", "-first"},
            {"Condition Two", "-second"},
            {"Condition Three", "-third"},
            {"Condition Four", "-fourth"},
            {"Condition Five", "-fifth"},
            {"Condition Six", "-sixth"},
            {"Condition Seven", "-seventh"},
            {"Condition Eight", "-eighth"},
        };
    }
}
