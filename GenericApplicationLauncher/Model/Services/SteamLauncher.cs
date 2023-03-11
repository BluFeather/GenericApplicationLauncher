using GenericApplicationLauncher.Model.Types;
using System.Collections.Generic;
using System.Collections.ObjectModel;

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
        }

        public ObservableCollection<IPreset> Presets { get; }

        public ObservableCollection<IParameter> SingleParameters { get; }

        public IParameterSelection LocaleOptions { get; }

        public IParameterSelection GenericOptionsOne { get; }

        public IParameterSelection GenericOptionsTwo { get; }

        public IParameterSelection GenericOptionsThree { get; }

        public string CustomParameter { get; set; } = string.Empty;

        public string ArgumentsString
        {
            get
            {
                HashSet<string> args = new HashSet<string>();

                foreach (var parameter in SingleParameters)
                {
                    if (parameter.IsEnabled)
                    {
                        args.Add(parameter.Value);
                    }
                }

                args.Add(LocaleOptions.Value);
                args.Add(GenericOptionsOne.Value);
                args.Add(GenericOptionsTwo.Value);
                args.Add(GenericOptionsThree.Value);

                args.Remove(string.Empty);

                return string.Join(" ", args);
            }
        }
    }
}
