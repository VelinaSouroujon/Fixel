using Fixel.Data.Models;
using Fixel.ViewModels.Constants;
using System.ComponentModel.DataAnnotations;

namespace Fixel.ViewModels.Devices.Details
{
    public class DeviceTicketViewModel
    {
        public int Id { get; set; }

        public string ReferenceNumber { get; set; } = null!;

        public string ReportedProblem { get; set; } = null!;

        [DisplayFormat(DataFormatString = DisplayFormats.Date)]
        public DateTime IntakeDate { get; set; }

        [DisplayFormat(DataFormatString = DisplayFormats.Date, NullDisplayText = DisplayFormats.Empty)]
        public DateOnly? ExpectedCompletionDate { get; set; }

        public RepairPriority Priority { get; set; }

        public RepairStatus Status { get; set; }

        public bool IsOverdue { get; set; }
    }
}
