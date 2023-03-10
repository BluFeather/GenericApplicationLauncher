using System.Collections.Generic;

namespace GenericApplicationLauncher.Model.Types
{
    public interface IParameterSelection
    {
        public List<Parameter> Parameters { get; }

        public List<string> ParameterLabels { get; }

        public int SelectedIndex { get; set; }
    }
}
