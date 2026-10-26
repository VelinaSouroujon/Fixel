using System.ComponentModel.DataAnnotations;
using Fixel.Data.Models;
using Fixel.ViewModels.Constants;

namespace Fixel.ViewModels.Customers.Details
{
    public class CustomerTicketViewModel
    {
        public int Id { get; set; }

        public string ReferenceNumber { get; set; } = null!;

        public string DeviceModelName { get; set; } = null!;

        public string DeviceManufacturerName { get; set; } = null!;

        [DisplayFormat(DataFormatString = DisplayFormats.Date)]
        public DateTime IntakeDate { get; set; }

        public RepairStatus RepairStatus { get; set; }
    }
}
