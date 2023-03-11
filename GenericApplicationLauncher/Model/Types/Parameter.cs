using System.Collections.Generic;

namespace GenericApplicationLauncher.Model.Types
{
    public class Parameter : IParameter
    {
        public Parameter(string label, string value)
        {
            Label = label;
            Value = value;
        }

        public string Label { get; }

        public string Value { get; }

        public bool IsEnabled { get; set; } = false;

        public static List<Parameter> GenerateParameterList(Dictionary<string, string> parameterDictionary)
        {
            var parameterList = new List<Parameter>();
            foreach (KeyValuePair<string, string> kvp in parameterDictionary)
            {
                parameterList.Add(new Parameter(kvp.Key, kvp.Value));
            }
            return parameterList;
        }
    }
}
