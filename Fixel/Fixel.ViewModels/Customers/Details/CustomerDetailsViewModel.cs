using System.ComponentModel.DataAnnotations;
using Fixel.Data.Models;
using Fixel.ViewModels.Constants;

namespace Fixel.ViewModels.Customers.Details
{
    public class CustomerDetailsViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        [DisplayFormat(NullDisplayText = DisplayFormats.Empty)]
        public string? Email { get; set; }

        public ContactMethod PreferredContactMethod { get; set; }

        public IEnumerable<CustomerDeviceViewModel> Devices { get; set; } = new List<CustomerDeviceViewModel>();

        public IEnumerable<CustomerTicketViewModel> RepairTickets { get; set; } = new List<CustomerTicketViewModel>();
    }
}
