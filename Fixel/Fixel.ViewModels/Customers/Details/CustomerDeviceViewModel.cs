using System.ComponentModel.DataAnnotations;
using Fixel.ViewModels.Constants;

namespace Fixel.ViewModels.Customers.Details
{
    public class CustomerDeviceViewModel
    {
        public int Id { get; set; }

        public string ManufacturerName { get; set; } = null!;

        public string DeviceModel { get; set; } = null!;

        public string DeviceType { get; set; } = null!;

        [DisplayFormat(NullDisplayText = DisplayFormats.Empty)]
        public string? SerialNumber { get; set; }
    }
}
