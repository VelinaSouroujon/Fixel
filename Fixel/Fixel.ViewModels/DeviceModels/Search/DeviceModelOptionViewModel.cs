using Fixel.ViewModels.Common;

namespace Fixel.ViewModels.DeviceModels.Search
{
    public class DeviceModelOptionViewModel : ISearchOptionViewModel
    {
        public int Id { get; set; }

        public string ManufacturerName { get; set; } = null!;

        public string ModelName { get; set; } = null!;

        public string DeviceType { get; set; } = null!;

        public string PrimaryText => $"{ManufacturerName} {ModelName}";

        public string SecondaryText => DeviceType;

        public string DisplayText => $"{ManufacturerName} {ModelName} ({DeviceType})";
    }
}
