using Fixel.Data.Models;

namespace Fixel.ViewModels.RepairTickets.Details
{
    public class TicketDetailsViewModel
    {
        public int Id { get; set; }

        public string ReferenceNumber { get; set; } = null!;

        public DateTime IntakeDate { get; set; }

        public string ConditionDescription { get; set; } = null!;

        public string ReportedProblem { get; set; } = null!;

        public RepairStatus Status { get; set; }

        public RepairPriority Priority { get; set; }

        public DateOnly? ExpectedCompletionDate { get; set; }

        public bool IsOverdue { get; set; }

        public int DeviceId { get; set; }

        public string DeviceManufacturerName { get; set; } = null!;

        public string DeviceModelName { get; set; } = null!;

        public string DeviceType { get; set; } = null!;

        public string? DeviceSerialNumber { get; set; }

        public int? CustomerId { get; set; }

        public string? CustomerFirstName { get; set; }

        public string? CustomerLastName { get; set; }

        public string? CustomerPhoneNumber { get; set; }
    }
}
