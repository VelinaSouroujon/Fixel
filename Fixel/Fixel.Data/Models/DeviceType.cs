using System.ComponentModel.DataAnnotations;

using static Fixel.Common.Constants.DeviceTypeConstants;

namespace Fixel.Data.Models
{
    public class DeviceType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TypeNameMaxLength)]
        public string TypeName { get; set; } = null!;

        public ICollection<Device> Devices { get; set; } = new List<Device>();
    }
}
