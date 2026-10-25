using Fixel.Data.Models;

using static Fixel.Data.Seeding.DeviceTypeSeedData;
using static Fixel.Data.Seeding.ManufacturerSeedData;

namespace Fixel.Data.Seeding
{
    public static class DeviceModelSeedData
    {
        public static IReadOnlyList<DeviceModel> DeviceModels { get; } = new List<DeviceModel>
        {
            new DeviceModel { Id = 1, Name = "iPhone 15", DeviceTypeId = Phone, ManufacturerId = Apple },
            new DeviceModel { Id = 2, Name = "iPhone 14", DeviceTypeId = Phone, ManufacturerId = Apple },
            new DeviceModel { Id = 3, Name = "iPad Air", DeviceTypeId = Tablet, ManufacturerId = Apple },
            new DeviceModel { Id = 4, Name = "MacBook Air M2", DeviceTypeId = Laptop, ManufacturerId = Apple },
            new DeviceModel { Id = 5, Name = "MacBook Pro 14", DeviceTypeId = Laptop, ManufacturerId = Apple },
            new DeviceModel { Id = 6, Name = "iMac 24", DeviceTypeId = Desktop, ManufacturerId = Apple },
            new DeviceModel { Id = 7, Name = "Apple Watch Series 9", DeviceTypeId = Other, ManufacturerId = Apple },
            new DeviceModel { Id = 8, Name = "Galaxy S23", DeviceTypeId = Phone, ManufacturerId = Samsung },
            new DeviceModel { Id = 9, Name = "Galaxy A54", DeviceTypeId = Phone, ManufacturerId = Samsung },
            new DeviceModel { Id = 10, Name = "Galaxy Tab S9", DeviceTypeId = Tablet, ManufacturerId = Samsung },
            new DeviceModel { Id = 11, Name = "XPS 15", DeviceTypeId = Laptop, ManufacturerId = Dell },
            new DeviceModel { Id = 12, Name = "Latitude 5420", DeviceTypeId = Laptop, ManufacturerId = Dell },
            new DeviceModel { Id = 13, Name = "OptiPlex 7090", DeviceTypeId = Desktop, ManufacturerId = Dell },
            new DeviceModel { Id = 14, Name = "Pavilion 15", DeviceTypeId = Laptop, ManufacturerId = Hp },
            new DeviceModel { Id = 15, Name = "EliteBook 840", DeviceTypeId = Laptop, ManufacturerId = Hp },
            new DeviceModel { Id = 16, Name = "EliteDesk 800", DeviceTypeId = Desktop, ManufacturerId = Hp },
            new DeviceModel { Id = 17, Name = "ThinkPad T14", DeviceTypeId = Laptop, ManufacturerId = Lenovo },
            new DeviceModel { Id = 18, Name = "IdeaPad 3", DeviceTypeId = Laptop, ManufacturerId = Lenovo },
            new DeviceModel { Id = 19, Name = "Legion 5", DeviceTypeId = Laptop, ManufacturerId = Lenovo },
            new DeviceModel { Id = 20, Name = "ROG Strix G15", DeviceTypeId = Laptop, ManufacturerId = Asus },
            new DeviceModel { Id = 21, Name = "Zenbook 14", DeviceTypeId = Laptop, ManufacturerId = Asus },
            new DeviceModel { Id = 22, Name = "Aspire 5", DeviceTypeId = Laptop, ManufacturerId = Acer },
            new DeviceModel { Id = 23, Name = "Nitro 5", DeviceTypeId = Laptop, ManufacturerId = Acer },
            new DeviceModel { Id = 24, Name = "Katana 15", DeviceTypeId = Laptop, ManufacturerId = Msi },
            new DeviceModel { Id = 25, Name = "Surface Pro 9", DeviceTypeId = Tablet, ManufacturerId = MicrosoftManufacturer },
            new DeviceModel { Id = 26, Name = "Surface Laptop 5", DeviceTypeId = Laptop, ManufacturerId = MicrosoftManufacturer },
            new DeviceModel { Id = 27, Name = "Xbox Series X", DeviceTypeId = ConsoleDevice, ManufacturerId = MicrosoftManufacturer },
            new DeviceModel { Id = 28, Name = "Xbox Series S", DeviceTypeId = ConsoleDevice, ManufacturerId = MicrosoftManufacturer },
            new DeviceModel { Id = 29, Name = "PlayStation 5", DeviceTypeId = ConsoleDevice, ManufacturerId = Sony },
            new DeviceModel { Id = 30, Name = "PlayStation 4 Pro", DeviceTypeId = ConsoleDevice, ManufacturerId = Sony },
            new DeviceModel { Id = 31, Name = "Xperia 1 V", DeviceTypeId = Phone, ManufacturerId = Sony },
            new DeviceModel { Id = 32, Name = "Switch", DeviceTypeId = ConsoleDevice, ManufacturerId = Nintendo },
            new DeviceModel { Id = 33, Name = "Switch OLED", DeviceTypeId = ConsoleDevice, ManufacturerId = Nintendo },
            new DeviceModel { Id = 34, Name = "Pixel 8", DeviceTypeId = Phone, ManufacturerId = Google },
            new DeviceModel { Id = 35, Name = "Pixel 7a", DeviceTypeId = Phone, ManufacturerId = Google },
            new DeviceModel { Id = 36, Name = "Redmi Note 12", DeviceTypeId = Phone, ManufacturerId = Xiaomi },
            new DeviceModel { Id = 37, Name = "Xiaomi 13", DeviceTypeId = Phone, ManufacturerId = Xiaomi },
            new DeviceModel { Id = 38, Name = "P30 Pro", DeviceTypeId = Phone, ManufacturerId = Huawei },
            new DeviceModel { Id = 39, Name = "MatePad 11", DeviceTypeId = Tablet, ManufacturerId = Huawei },
            new DeviceModel { Id = 40, Name = "Moto G54", DeviceTypeId = Phone, ManufacturerId = Motorola },
            new DeviceModel { Id = 41, Name = "Edge 40", DeviceTypeId = Phone, ManufacturerId = Motorola },
            new DeviceModel { Id = 42, Name = "OnePlus 11", DeviceTypeId = Phone, ManufacturerId = OnePlus }
        }.AsReadOnly();
    }
}
