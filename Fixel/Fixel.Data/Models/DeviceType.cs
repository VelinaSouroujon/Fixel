using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using static Fixel.Common.Constants.DeviceTypeConstants;

namespace Fixel.Data.Models
{
    [Index(nameof(TypeName), IsUnique = true)]
    public class DeviceType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TypeNameMaxLength)]
        public string TypeName { get; set; } = null!;

        public ICollection<DeviceModel> DeviceModels { get; set; } = new List<DeviceModel>();
    }
}
