using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Fixel.Common.Constants.RepairTicketConstants;

namespace Fixel.Data.Models
{
    [Index(nameof(ReferenceNumber), IsUnique = true)]
    public class RepairTicket
    {
        [Key]
        public int Id { get; set; }

        public string ReferenceNumber { get; set; } = null!;

        [Required]
        public DateTime IntakeDate { get; set; }

        [Required]
        [MaxLength(ConditionDescriptionMaxLength)]
        public string ConditionDescription { get; set; } = null!;

        [Required]
        [MaxLength(ReportedProblemMaxLength)]
        public string ReportedProblem { get; set; } = null!;

        [Required]
        public Priority Priority { get; set; }

        public DateOnly? ExpectedCompletionDate { get; set; }

        [Required]
        public Status Status { get; set; }

        public int DeviceId { get; set; }

        [ForeignKey(nameof(DeviceId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Device Device { get; set; } = null!;
    }

    public enum Priority
    {
        Low = 1,
        Normal = 2,
        High = 3,
        Urgent = 4
    }

    public enum Status
    {
        Received = 1,
        Diagnosing = 2,
        AwaitingApproval = 3,
        Approved = 4,
        WaitingForParts = 5,
        InRepair = 6,
        Testing = 7,
        ReadyForCollection = 8,
        Collected = 9,
        Declined = 10,
        Unrepairable = 11,
        Cancelled = 12
    }
}
