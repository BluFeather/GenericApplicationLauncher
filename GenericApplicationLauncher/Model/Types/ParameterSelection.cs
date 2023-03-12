using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace GenericApplicationLauncher.Model.Types
{
    public class ParameterSelection : IParameterSelection, INotifyPropertyChanged
    {
        public ParameterSelection(List<Parameter> parameters)
        {
            Parameters = parameters;
        }

        public List<Parameter> Parameters { get; }

        public List<string> ParameterLabels
        {
            get
            {
                var parameterLabels = new List<string>();
                foreach (var parameter in Parameters)
                {
                    parameterLabels.Add(parameter.Label);
                }
                return parameterLabels;
            }
        }

        private int selectedIndex = 0;
        public int SelectedIndex
        {
            get => selectedIndex;
            set
            {
                selectedIndex = value;
                OnPropertyChanged();
            }
        }
        public string Value => Parameters[SelectedIndex].Value;

        public bool TryApplyPreset(Preset preset)
        {
            foreach (var parameter in Parameters)
            {
                if (parameter.TryApplyPreset(preset))
                {
                    SelectedIndex = Parameters.IndexOf(parameter);
                    return true;
                }
            }
            SelectedIndex = 0;
            return false;
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
