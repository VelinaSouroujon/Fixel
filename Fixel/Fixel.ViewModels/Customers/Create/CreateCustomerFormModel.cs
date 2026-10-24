using Fixel.Data.Models;
using System.ComponentModel.DataAnnotations;

using static Fixel.Common.Constants.CustomerConstants;

namespace Fixel.ViewModels.Customers.Create
{
    public class CreateCustomerFormModel
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
    }
}
