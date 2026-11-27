using Fixel.ViewModels.Common;

namespace Fixel.ViewModels.Devices.Search
{
    public class DeviceOptionViewModel : ISearchOptionViewModel
    {
        public int Id { get; set; }

        public string ManufacturerName { get; set; } = null!;

        public string ModelName { get; set; } = null!;

        public string? SerialNumber { get; set; }

        public string? CustomerFirstName { get; set; }

        public string? CustomerLastName { get; set; }

        public string PrimaryText => SerialNumber is not null
            ? $"{ManufacturerName} {ModelName} ({SerialNumber})"
            : $"{ManufacturerName} {ModelName}";

        public string SecondaryText => CustomerFirstName is not null
            ? $"{CustomerFirstName} {CustomerLastName}"
            : "No owner";

        public string DisplayText => CustomerFirstName is not null
            ? $"{ManufacturerName} {ModelName} ({CustomerFirstName} {CustomerLastName})"
            : $"{ManufacturerName} {ModelName}";
    }
}