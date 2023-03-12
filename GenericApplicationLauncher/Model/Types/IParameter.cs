namespace GenericApplicationLauncher.Model.Types
{
    public interface IParameter
    {
        public string Label { get; }

        public string Value { get; }

        public bool IsEnabled { get; set; }

        public bool TryApplyPreset(Preset preset);
    }
}
