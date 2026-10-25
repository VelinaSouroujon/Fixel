using Fixel.Data.Models;

namespace Fixel.Data.Seeding
{
    public static class ManufacturerSeedData
    {
        public const int Apple = 1;
        public const int Samsung = 2;
        public const int Dell = 3;
        public const int Hp = 4;
        public const int Lenovo = 5;
        public const int Asus = 6;
        public const int Acer = 7;
        public const int Msi = 8;
        public const int MicrosoftManufacturer = 9;
        public const int Sony = 10;
        public const int Nintendo = 11;
        public const int Google = 12;
        public const int Xiaomi = 13;
        public const int Huawei = 14;
        public const int Motorola = 15;
        public const int OnePlus = 16;
        public static IReadOnlyList<Manufacturer> Manufacturers { get; } = new List<Manufacturer>
        {
            new Manufacturer { Id = Apple, Name = "Apple" },
            new Manufacturer { Id = Samsung, Name = "Samsung" },
            new Manufacturer { Id = Dell, Name = "Dell" },
            new Manufacturer { Id = Hp, Name = "HP" },
            new Manufacturer { Id = Lenovo, Name = "Lenovo" },
            new Manufacturer { Id = Asus, Name = "ASUS" },
            new Manufacturer { Id = Acer, Name = "Acer" },
            new Manufacturer { Id = Msi, Name = "MSI" },
            new Manufacturer { Id = MicrosoftManufacturer, Name = "Microsoft" },
            new Manufacturer { Id = Sony, Name = "Sony" },
            new Manufacturer { Id = Nintendo, Name = "Nintendo" },
            new Manufacturer { Id = Google, Name = "Google" },
            new Manufacturer { Id = Xiaomi, Name = "Xiaomi" },
            new Manufacturer { Id = Huawei, Name = "Huawei" },
            new Manufacturer { Id = Motorola, Name = "Motorola" },
            new Manufacturer { Id = OnePlus, Name = "OnePlus" }
        }.AsReadOnly();
    }
}
