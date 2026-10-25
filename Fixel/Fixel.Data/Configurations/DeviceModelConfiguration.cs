using Fixel.Data.Models;
using Fixel.Data.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Fixel.Data.Configurations
{
    public class DeviceModelConfiguration : IEntityTypeConfiguration<DeviceModel>
    {
        public void Configure(EntityTypeBuilder<DeviceModel> builder)
        {
            builder.HasData(DeviceModelSeedData.DeviceModels);
        }
    }
}
