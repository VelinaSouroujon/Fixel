using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static Fixel.Common.Constants.ManufacturerConstants;

namespace Fixel.Data.Models
{
    [Index(nameof(Name), IsUnique = true)]
    public class Manufacturer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<DeviceModel> DeviceModels { get; set; } = new List<DeviceModel>();
    }
}
