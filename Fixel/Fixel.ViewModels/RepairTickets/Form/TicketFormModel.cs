using System.ComponentModel.DataAnnotations;
using Fixel.Data.Models;

using static Fixel.Common.Constants.RepairTicketConstants;

namespace Fixel.ViewModels.RepairTickets.Form
{
    public class TicketFormModel : IValidatableObject
    {
        [Required]
        [StringLength(ReferenceNumberLength, MinimumLength = ReferenceNumberLength, 
            ErrorMessage = "Reference number must be exactly {1} characters long")]
        public string ReferenceNumber { get; set; } = null!;

        [Required]
        public int DeviceId { get; set; }

        [Required]
        [MinLength(ConditionDescriptionMinLength)]
        [MaxLength(ConditionDescriptionMaxLength)]
        public string ConditionDescription { get; set; } = null!;

        [Required]
        [MinLength(ReportedProblemMinLength)]
        [MaxLength(ReportedProblemMaxLength)]
        public string ReportedProblem { get; set; } = null!;

        [Required]
        public RepairPriority Priority { get; set; } = RepairPriority.Normal;

        public DateOnly? ExpectedCompletionDate { get; set; }

        public IEnumerable<TicketDeviceOptionViewModel> Devices { get; set; } = new List<TicketDeviceOptionViewModel>();

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            DateOnly todayDate = DateOnly.FromDateTime(DateTime.Today);

            if (ExpectedCompletionDate is not null && ExpectedCompletionDate < todayDate)
            {
                yield return new ValidationResult(
                    "Expected completion date can't be a date before today",
                    new[] { nameof(ExpectedCompletionDate) });
            }
        }
    }
}