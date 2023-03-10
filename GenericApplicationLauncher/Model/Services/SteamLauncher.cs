using GenericApplicationLauncher.Model.Types;
using System.Collections.ObjectModel;
using System.Diagnostics;

namespace GenericApplicationLauncher.Model.Services
{
    public class SteamLauncher : ISteamLauncher
    {
        public SteamLauncher()
        {
            Presets = new ObservableCollection<IPreset>(Preset.GeneratePresetList(SteamParameters.Presets));
            SingleParameters = new ObservableCollection<IParameter>(Parameter.GenerateParameterList(SteamParameters.SingleSteamParameters));
            LocaleOptions = new ParameterSelection(Parameter.GenerateParameterList(SteamParameters.LocaleOptions));
            GenericOptionsOne = new ParameterSelection(Parameter.GenerateParameterList(SteamParameters.GenericOptionsOne));
            GenericOptionsTwo = new ParameterSelection(Parameter.GenerateParameterList(SteamParameters.GenericOptionsTwo));
            GenericOptionsThree = new ParameterSelection(Parameter.GenerateParameterList(SteamParameters.GenericOptionsThree));

            Debug.WriteLine(Presets.Count);
        }

        public ObservableCollection<IPreset> Presets { get; }

        public ObservableCollection<IParameter> SingleParameters { get; }

        public IParameterSelection LocaleOptions { get; }

        public IParameterSelection GenericOptionsOne { get; }

        public IParameterSelection GenericOptionsTwo { get; }

        public IParameterSelection GenericOptionsThree { get; }
    }
}
