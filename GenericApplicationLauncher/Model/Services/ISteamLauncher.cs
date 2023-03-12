using GenericApplicationLauncher.Model.Types;
using System;
using System.Collections.ObjectModel;

namespace GenericApplicationLauncher.Model.Services
{
    public interface ISteamLauncher
    {
        ObservableCollection<IPreset> Presets { get; }

        ObservableCollection<IParameter> SingleParameters { get; }

        IParameterSelection LocaleOptions { get; }

        IParameterSelection GenericOptionsOne { get; }

        IParameterSelection GenericOptionsTwo { get; }

        IParameterSelection GenericOptionsThree { get; }

        string CustomParameter { get; set; }

        string ArgumentsString { get; }

        bool TryLaunchSteam();
    }
}
