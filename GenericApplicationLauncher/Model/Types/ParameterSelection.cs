using System.Collections.Generic;

namespace GenericApplicationLauncher.Model.Types
{
    public class ParameterSelection
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

        public int SelectedIndex { get; set; } = 0;
    }
}
