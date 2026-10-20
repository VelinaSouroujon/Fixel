using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Fixel.Common.Constants.DeviceModelConstants;

namespace Fixel.Data.Models
{
    [Index(nameof(ManufacturerId), nameof(Name), IsUnique = true)]
    public class DeviceModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        public int DeviceTypeId { get; set; }

        [ForeignKey(nameof(DeviceTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public DeviceType DeviceType { get; set; } = null!;

        [Required]
        public int ManufacturerId { get; set; }

        [ForeignKey(nameof(ManufacturerId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Manufacturer Manufacturer { get; set; } = null!;

        public ICollection<Device> Devices { get; set; } = new List<Device>();
    }
}
