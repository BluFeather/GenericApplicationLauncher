using GenericApplicationLauncher.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;

namespace GenericApplicationLauncher.Model.Types
{
    public class Preset : IPreset
    {
        public Preset(string label, HashSet<string> parametersToToggle)
        {
            this.Label = label;
            ParametersToToggle = parametersToToggle;
            PresetCommand = new RelayCommand(PresetCommandInvoked);
        }

        public string Label { get; }

        public HashSet<string> ParametersToToggle { get; }

        public static List<Preset> GeneratePresetList(Dictionary<string, HashSet<string>> presetDictionary, EventHandler<Preset> OnPresetClicked)
        {
            List<Preset> list = new List<Preset>();
            foreach (var kvp in presetDictionary)
            {
                var preset = new Preset(kvp.Key, kvp.Value);
                preset.PresetClicked += OnPresetClicked;
                list.Add(preset);
            }
            return list;
        }

        public ICommand PresetCommand { get; }

        public event EventHandler<Preset> PresetClicked;

        private void PresetCommandInvoked()
        {
            PresetClicked?.Invoke(this, this);
        }
    }
}
