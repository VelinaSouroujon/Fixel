using Fixel.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using static Fixel.Common.Constants.RepairTicketConstants;

namespace Fixel.Data.Configurations
{
    public class RepairTicketConfiguration : IEntityTypeConfiguration<RepairTicket>
    {
        public void Configure(EntityTypeBuilder<RepairTicket> builder)
        {
            builder.Property(rt => rt.ReferenceNumber)
                .HasColumnType($"char({ReferenceNumberLength})");
        }
    }
}
