using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Fixel.Common.Constants.DeviceConstants;

namespace Fixel.Data.Models
{
    [Index(nameof(SerialNumber), IsUnique = true)]
    public class Device
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int DeviceTypeId { get; set; }

        [ForeignKey(nameof(DeviceTypeId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public DeviceType DeviceType { get; set; } = null!;

        [Required]
        public int ModelId { get; set; }

        [ForeignKey(nameof(ModelId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public DeviceModel Model { get; set; } = null!;

        [MaxLength(SerialNumberMaxLength)]
        public string? SerialNumber { get; set; }

        public int? CustomerId { get; set; }

        [ForeignKey(nameof(CustomerId))]
        [DeleteBehavior(DeleteBehavior.SetNull)]
        public Customer? Customer { get; set; }

        public ICollection<RepairTicket> RepairTickets { get; set; } = new List<RepairTicket>();
    }
}
