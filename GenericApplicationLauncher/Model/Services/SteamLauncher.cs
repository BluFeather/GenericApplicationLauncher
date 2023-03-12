using GenericApplicationLauncher.Model.Types;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Windows;

namespace GenericApplicationLauncher.Model.Services
{
    public class SteamLauncher : ISteamLauncher
    {
        public SteamLauncher()
        {
            Presets = new ObservableCollection<IPreset>(Preset.GeneratePresetList(SteamParameters.Presets, PresetClicked));
            SingleParameters = new ObservableCollection<IParameter>(Parameter.GenerateParameterList(SteamParameters.SingleSteamParameters));
            LocaleOptions = new ParameterSelection(Parameter.GenerateParameterList(SteamParameters.LocaleOptions));
            GenericOptionsOne = new ParameterSelection(Parameter.GenerateParameterList(SteamParameters.GenericOptionsOne));
            GenericOptionsTwo = new ParameterSelection(Parameter.GenerateParameterList(SteamParameters.GenericOptionsTwo));
            GenericOptionsThree = new ParameterSelection(Parameter.GenerateParameterList(SteamParameters.GenericOptionsThree));
            SteamExecutable = new FileInfo(Path.Combine(@"C:\Program Files (x86)\Steam\steam.exe"));
        }

        private void PresetClicked(object? sender, Preset preset)
        {
            foreach (var parameter in SingleParameters)
            {
                parameter.TryApplyPreset(preset);
            }
            LocaleOptions.TryApplyPreset(preset);
            GenericOptionsOne.TryApplyPreset(preset);
            GenericOptionsTwo.TryApplyPreset(preset);
            GenericOptionsThree.TryApplyPreset(preset);
            CustomParameter = string.Empty;
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
                args.Add(CustomParameter);

                args.Remove(string.Empty);

                return string.Join(" ", args);
            }
        }

        public FileInfo SteamExecutable { get; }

        private void KillSteamProcess()
        {
            foreach (Process process in Process.GetProcessesByName("steam"))
            {
                process.Kill();
            }
        }

        public bool TryLaunchSteam()
        {
            if (!SteamExecutable.Exists) return false;

            KillSteamProcess();
            Process steamProcess = new Process();
            steamProcess.StartInfo.FileName = SteamExecutable.FullName;
            steamProcess.StartInfo.Arguments = ArgumentsString;
            try
            {
                steamProcess.Start();
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show($"Steam.exe failed to start! Maybe the following exception message can help determine why:\n{e.Message}", "Error Starting Steam!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return false;
        }
    }
}
