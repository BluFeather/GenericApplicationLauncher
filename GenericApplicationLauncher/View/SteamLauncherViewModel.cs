using GenericApplicationLauncher.Model.Services;
using GenericApplicationLauncher.Model.Types;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Timers;

namespace GenericApplicationLauncher.View
{
    public class SteamLauncherViewModel : INotifyPropertyChanged
    {
        protected ISteamLauncher SteamLauncher { get; }

        private Timer _refreshTimer = new Timer(50);

        private void RefreshView(object? sender, ElapsedEventArgs e)
        {
            OnPropertyChanged("ArgumentsString");
            OnPropertyChanged("CustomParameter");
        }

        public SteamLauncherViewModel()
        {
            SteamLauncher = new SteamLauncher();
            _refreshTimer.Elapsed += RefreshView;
            _refreshTimer.Start();
        }

        public ObservableCollection<IPreset> Presets => SteamLauncher.Presets;

        public ObservableCollection<IParameter> SingleParameters => SteamLauncher.SingleParameters;

        public IParameterSelection LocaleOptions => SteamLauncher.LocaleOptions;

        public IParameterSelection GenericOptionsOne => SteamLauncher.GenericOptionsOne;

        public IParameterSelection GenericOptionsTwo => SteamLauncher.GenericOptionsTwo;

        public IParameterSelection GenericOptionsThree => SteamLauncher.GenericOptionsThree;

        public string CustomParameter
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
