using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GenericApplicationLauncher.Model.Types
{
    public class Parameter : IParameter, INotifyPropertyChanged
    {
        public Parameter(string label, string value)
        {
            Label = label;
            Value = value;
        }

        public string Label { get; }

        public string Value { get; }

        private bool isEnabled = false;
        public bool IsEnabled
        {
            get => isEnabled;
            set
            {
                isEnabled = value;
                OnPropertyChanged();
            }
        }

        public bool TryApplyPreset(Preset preset)
        {
            IsEnabled = preset.ParametersToToggle.Contains(Value) || preset.ParametersToToggle.Contains(Label);
            return IsEnabled;
        }

        public static List<Parameter> GenerateParameterList(Dictionary<string, string> parameterDictionary)
        {
            var parameterList = new List<Parameter>();
            foreach (KeyValuePair<string, string> kvp in parameterDictionary)
            {
                parameterList.Add(new Parameter(kvp.Key, kvp.Value));
            }
            return parameterList;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
