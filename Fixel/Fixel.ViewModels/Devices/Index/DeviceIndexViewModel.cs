using Fixel.ViewModels.Constants;
using System.ComponentModel.DataAnnotations;

namespace Fixel.ViewModels.Devices.Index
{
    public class DeviceIndexViewModel
    {
        public int Id { get; set; }

        public string ManufacturerName { get; set; } = null!;

        public string ModelName { get; set; } = null!;

        public string DeviceType { get; set; } = null!;

        [DisplayFormat(NullDisplayText = DisplayFormats.Empty)]
        public string? SerialNumber { get; set; }

        public int? CustomerId { get; set; }

        [DisplayFormat(NullDisplayText = DisplayFormats.Empty)]
        public string? CustomerFirstName { get; set; }

        public string? CustomerLastName { get; set; }

        public int TicketsCount { get; set; }

        public int ActiveTicketsCount { get; set; }
    }
}
