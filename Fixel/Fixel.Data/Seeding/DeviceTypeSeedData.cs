using Fixel.Data.Models;

namespace Fixel.Data.Seeding
{
    public static class DeviceTypeSeedData
    {
        public const int Laptop = 1;
        public const int Desktop = 2;
        public const int Phone = 3;
        public const int Tablet = 4;
        public const int ConsoleDevice = 5;
        public const int Other = 6;
        public static IReadOnlyList<DeviceType> DeviceTypes { get; } = new List<DeviceType>
        {
            new DeviceType { Id = Laptop, TypeName = "Laptop" },
            new DeviceType { Id = Desktop, TypeName = "Desktop" },
            new DeviceType { Id = Phone, TypeName = "Phone" },
            new DeviceType { Id = Tablet, TypeName = "Tablet" },
            new DeviceType { Id = ConsoleDevice, TypeName = "Console" },
            new DeviceType { Id = Other, TypeName = "Other" }
        }.AsReadOnly();
    }
}
