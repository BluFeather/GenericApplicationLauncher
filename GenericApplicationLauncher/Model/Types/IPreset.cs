using GenericApplicationLauncher.View;
using System.Collections.Generic;
using System.Windows.Input;

namespace GenericApplicationLauncher.Model.Types
{
    public interface IPreset
    {
        public string Label { get; }

        public HashSet<string> ParametersToToggle { get; }

        public ICommand PresetCommand { get; }
    }
}
