using GenericApplicationLauncher.Model.Services;
using GenericApplicationLauncher.Model.Types;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GenericApplicationLauncher.View
{
    public class SteamLauncherViewModel : INotifyPropertyChanged
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

        public string CustomProperty
        {
            get => SteamLauncher.CustomParameter;
            set
            {
                SteamLauncher.CustomParameter = value;
                OnPropertyChanged();
            }
        }

        public string ArgumentsString { get => SteamLauncher.ArgumentsString; }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
