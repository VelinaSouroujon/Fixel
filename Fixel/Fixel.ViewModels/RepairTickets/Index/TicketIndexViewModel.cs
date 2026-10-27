using System.ComponentModel.DataAnnotations;
using Fixel.Data.Models;
using Fixel.ViewModels.Constants;

namespace Fixel.ViewModels.RepairTickets.Index
{
    public class TicketIndexViewModel
    {
        public int Id { get; set; }

        public string ReferenceNumber { get; set; } = null!;

        [DisplayFormat(NullDisplayText = DisplayFormats.Empty)]
        public string? CustomerFirstName { get; set; }

        public string? CustomerLastName { get; set; }

        public string DeviceManufacturerName { get; set; } = null!;

        public string DeviceModelName { get; set; } = null!;

        public RepairStatus Status { get; set; }

        public RepairPriority Priority { get; set; }

        [DisplayFormat(DataFormatString = DisplayFormats.Date, NullDisplayText = DisplayFormats.Empty)]
        public DateOnly? ExpectedCompletionDate { get; set; }

        public bool IsOverdue { get; set; }
    }
}
