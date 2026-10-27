using Fixel.Data.Models;
using System.ComponentModel.DataAnnotations;

using static Fixel.Common.Constants.CustomerConstants;

namespace Fixel.ViewModels.Customers.Form
{
    public class CustomerFormModel : IValidatableObject
    {
        [Required]
        [MinLength(FirstNameMinLength)]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MinLength(LastNameMinLength)]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [Phone]
        public string PhoneNumber { get; set; } = null!;

        [EmailAddress]
        public string? Email { get; set; }

        [Required]
        public ContactMethod PreferredContactMethod { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (Email is null && PreferredContactMethod == ContactMethod.Email)
            {
                yield return new ValidationResult(
                    "You can choose email as preferred contact method only in case email address is provided",
                    new[] { nameof(PreferredContactMethod) });
            }
        }
    }
}
