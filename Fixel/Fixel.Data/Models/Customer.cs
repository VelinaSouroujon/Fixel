using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static Fixel.Common.Constants.CustomerConstants;

namespace Fixel.Data.Models
{
    [Index(nameof(Email), IsUnique = true)]
    [Index(nameof(PhoneNumber))]
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(LastNameMaxLength)]
        public string LastName { get; set; } = null!;

        [Required]
        [MaxLength(PhoneNumberMaxLength)]
        public string PhoneNumber { get; set; } = null!;

        [MaxLength(EmailMaxLength)]
        public string? Email { get; set; }

        [Required]
        public ContactMethod PreferredContactMethod { get; set; }

        public ICollection<Device> Devices { get; set; } = new List<Device>();
    }

    public enum ContactMethod
    {
        Phone = 1,
        Email = 2,
        SMS = 3
    }
}
