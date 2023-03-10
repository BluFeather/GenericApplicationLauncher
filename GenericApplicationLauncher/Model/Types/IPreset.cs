using System.Collections.Generic;

namespace GenericApplicationLauncher.Model.Types
{
    public interface IPreset
    {
        public string Label { get; }

        public HashSet<string> ParametersToToggle { get; }
    }
}
