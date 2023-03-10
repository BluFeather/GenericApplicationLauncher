using System.Collections.Generic;

namespace GenericApplicationLauncher.Model.Types
{
    public class Preset : IPreset
    {
        public Preset(string label, HashSet<string> parametersToToggle)
        {
            this.Label = label;
            ParametersToToggle = parametersToToggle;
        }

        public string Label { get; }

        public HashSet<string> ParametersToToggle { get; }

        public static List<Preset> GeneratePresetList(Dictionary<string, HashSet<string>> presetDictionary)
        {
            List<Preset> list = new List<Preset>();
            foreach (var kvp in presetDictionary)
            {
                list.Add(new Preset(kvp.Key, kvp.Value));
            }
            return list;
        }
    }
}
