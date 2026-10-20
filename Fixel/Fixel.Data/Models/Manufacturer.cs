using System.ComponentModel.DataAnnotations;

using static Fixel.Common.Constants.ManufacturerConstants;

namespace Fixel.Data.Models
{
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
