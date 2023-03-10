using GenericApplicationLauncher.Model.Services;
using GenericApplicationLauncher.Model.Types;
using System.Collections.ObjectModel;

namespace GenericApplicationLauncher.View
{
    public class SteamLauncherViewModel
    {
        protected ISteamLauncher SteamLauncher { get; }

        public SteamLauncherViewModel()
        {
            SteamLauncher = new SteamLauncher();
        }

        public ObservableCollection<IPreset> Presets => SteamLauncher.Presets;

        public ObservableCollection<IParameter> SingleParameters => SteamLauncher.SingleParameters;

        public IParameterSelection LocaleOptions => SteamLauncher.LocaleOptions;

        public IParameterSelection GenericOptionsOne => SteamLauncher.GenericOptionsOne;

        public IParameterSelection GenericOptionsTwo => SteamLauncher.GenericOptionsTwo;

        public IParameterSelection GenericOptionsThree => SteamLauncher.GenericOptionsThree;
    }
}
