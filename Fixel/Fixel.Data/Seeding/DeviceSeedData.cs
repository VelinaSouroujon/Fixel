using Fixel.Data.Models;

using static Fixel.Data.Seeding.CustomerSeedData;
using static Fixel.Data.Seeding.DeviceModelSeedData;

namespace Fixel.Data.Seeding
{
    public static class DeviceSeedData
    {
        public static IReadOnlyList<Device> Devices { get; } = new List<Device>
        {
            new Device { Id = 1, ModelId = ModelIdFor(1), SerialNumber = "SN-2026-0001", CustomerId = CustomerIdFor(1) },
            new Device { Id = 2, ModelId = ModelIdFor(2), SerialNumber = "SN-2026-0002", CustomerId = CustomerIdFor(2) },
            new Device { Id = 3, ModelId = ModelIdFor(3), SerialNumber = "SN-2026-0003", CustomerId = CustomerIdFor(3) },
            new Device { Id = 4, ModelId = ModelIdFor(4), SerialNumber = "SN-2026-0004", CustomerId = CustomerIdFor(4) },
            new Device { Id = 5, ModelId = ModelIdFor(5), SerialNumber = "SN-2026-0005", CustomerId = CustomerIdFor(5) },
            new Device { Id = 6, ModelId = ModelIdFor(6), SerialNumber = "SN-2026-0006", CustomerId = CustomerIdFor(6) },
            new Device { Id = 7, ModelId = ModelIdFor(7), SerialNumber = "SN-2026-0007", CustomerId = CustomerIdFor(7) },
            new Device { Id = 8, ModelId = ModelIdFor(8), SerialNumber = "SN-2026-0008", CustomerId = CustomerIdFor(8) },
            new Device { Id = 9, ModelId = ModelIdFor(9), SerialNumber = "SN-2026-0009", CustomerId = CustomerIdFor(9) },
            new Device { Id = 10, ModelId = ModelIdFor(10), SerialNumber = "SN-2026-0010", CustomerId = CustomerIdFor(10) },
            new Device { Id = 11, ModelId = ModelIdFor(11), SerialNumber = null, CustomerId = CustomerIdFor(11) },
            new Device { Id = 12, ModelId = ModelIdFor(12), SerialNumber = "SN-2026-0012", CustomerId = CustomerIdFor(12) }
        }.AsReadOnly();

        private static int CustomerIdFor(int deviceId)
        {
            return Customers[(deviceId - 1) % Customers.Count].Id;
        }

        private static int ModelIdFor(int deviceId)
        {
            return DeviceModels[(deviceId - 1) % DeviceModels.Count].Id;
        }
    }
}
