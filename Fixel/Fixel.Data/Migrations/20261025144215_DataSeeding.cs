using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Fixel.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "PhoneNumber", "PreferredContactMethod" },
                values: new object[,]
                {
                    { 1, "elena.markovic@example.com", "Elena", "Marković", "+44 7700 900101", 2 },
                    { 2, "daniel.okafor@example.com", "Daniel", "Okafor", "+44 7700 900102", 1 },
                    { 3, "sofia.lindqvist@example.com", "Sofia", "Lindqvist", "+44 7700 900103", 3 },
                    { 4, null, "Mateo", "Fernández", "+44 7700 900104", 1 },
                    { 5, "aisha.rahman@example.com", "Aisha", "Rahman", "+44 7700 900105", 2 },
                    { 6, "thomas.becker@example.com", "Thomas", "Becker", "+44 7700 900106", 3 },
                    { 7, "nina.kowalska@example.com", "Nina", "Kowalska", "+44 7700 900107", 1 },
                    { 8, null, "Lucas", "Moreau", "+44 7700 900108", 3 },
                    { 9, "priya.nair@example.com", "Priya", "Nair", "+44 7700 900109", 2 },
                    { 10, "viktor.petrov@example.com", "Viktor", "Petrov", "+44 7700 900110", 1 }
                });

            migrationBuilder.InsertData(
                table: "DeviceTypes",
                columns: new[] { "Id", "TypeName" },
                values: new object[,]
                {
                    { 1, "Laptop" },
                    { 2, "Desktop" },
                    { 3, "Phone" },
                    { 4, "Tablet" },
                    { 5, "Console" },
                    { 6, "Other" }
                });

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Apple" },
                    { 2, "Samsung" },
                    { 3, "Dell" },
                    { 4, "HP" },
                    { 5, "Lenovo" },
                    { 6, "ASUS" },
                    { 7, "Acer" },
                    { 8, "MSI" },
                    { 9, "Microsoft" },
                    { 10, "Sony" },
                    { 11, "Nintendo" },
                    { 12, "Google" },
                    { 13, "Xiaomi" },
                    { 14, "Huawei" },
                    { 15, "Motorola" },
                    { 16, "OnePlus" }
                });

            migrationBuilder.InsertData(
                table: "DeviceModels",
                columns: new[] { "Id", "DeviceTypeId", "ManufacturerId", "Name" },
                values: new object[,]
                {
                    { 1, 3, 1, "iPhone 15" },
                    { 2, 3, 1, "iPhone 14" },
                    { 3, 4, 1, "iPad Air" },
                    { 4, 1, 1, "MacBook Air M2" },
                    { 5, 1, 1, "MacBook Pro 14" },
                    { 6, 2, 1, "iMac 24" },
                    { 7, 6, 1, "Apple Watch Series 9" },
                    { 8, 3, 2, "Galaxy S23" },
                    { 9, 3, 2, "Galaxy A54" },
                    { 10, 4, 2, "Galaxy Tab S9" },
                    { 11, 1, 3, "XPS 15" },
                    { 12, 1, 3, "Latitude 5420" },
                    { 13, 2, 3, "OptiPlex 7090" },
                    { 14, 1, 4, "Pavilion 15" },
                    { 15, 1, 4, "EliteBook 840" },
                    { 16, 2, 4, "EliteDesk 800" },
                    { 17, 1, 5, "ThinkPad T14" },
                    { 18, 1, 5, "IdeaPad 3" },
                    { 19, 1, 5, "Legion 5" },
                    { 20, 1, 6, "ROG Strix G15" },
                    { 21, 1, 6, "Zenbook 14" },
                    { 22, 1, 7, "Aspire 5" },
                    { 23, 1, 7, "Nitro 5" },
                    { 24, 1, 8, "Katana 15" },
                    { 25, 4, 9, "Surface Pro 9" },
                    { 26, 1, 9, "Surface Laptop 5" },
                    { 27, 5, 9, "Xbox Series X" },
                    { 28, 5, 9, "Xbox Series S" },
                    { 29, 5, 10, "PlayStation 5" },
                    { 30, 5, 10, "PlayStation 4 Pro" },
                    { 31, 3, 10, "Xperia 1 V" },
                    { 32, 5, 11, "Switch" },
                    { 33, 5, 11, "Switch OLED" },
                    { 34, 3, 12, "Pixel 8" },
                    { 35, 3, 12, "Pixel 7a" },
                    { 36, 3, 13, "Redmi Note 12" },
                    { 37, 3, 13, "Xiaomi 13" },
                    { 38, 3, 14, "P30 Pro" },
                    { 39, 4, 14, "MatePad 11" },
                    { 40, 3, 15, "Moto G54" },
                    { 41, 3, 15, "Edge 40" },
                    { 42, 3, 16, "OnePlus 11" }
                });

            migrationBuilder.InsertData(
                table: "Devices",
                columns: new[] { "Id", "CustomerId", "ModelId", "SerialNumber" },
                values: new object[,]
                {
                    { 1, 1, 1, "SN-2026-0001" },
                    { 2, 2, 2, "SN-2026-0002" },
                    { 3, 3, 3, "SN-2026-0003" },
                    { 4, 4, 4, "SN-2026-0004" },
                    { 5, 5, 5, "SN-2026-0005" },
                    { 6, 6, 6, "SN-2026-0006" },
                    { 7, 7, 7, "SN-2026-0007" },
                    { 8, 8, 8, "SN-2026-0008" },
                    { 9, 9, 9, "SN-2026-0009" },
                    { 10, 10, 10, "SN-2026-0010" },
                    { 11, 1, 11, null },
                    { 12, 2, 12, "SN-2026-0012" }
                });

            migrationBuilder.InsertData(
                table: "RepairTickets",
                columns: new[] { "Id", "ConditionDescription", "DeviceId", "ExpectedCompletionDate", "IntakeDate", "Priority", "ReferenceNumber", "ReportedProblem", "Status" },
                values: new object[,]
                {
                    { 1, "Light scuffs on the frame, screen intact.", 1, new DateOnly(2026, 7, 15), new DateTime(2026, 7, 8, 10, 15, 0, 0, DateTimeKind.Unspecified), 2, "FF-2026-0001", "Battery drops below 80% health and the phone dies at 20%.", 9 },
                    { 2, "Small dent on the top-left corner.", 2, new DateOnly(2026, 8, 18), new DateTime(2026, 8, 11, 14, 40, 0, 0, DateTimeKind.Unspecified), 2, "FF-2026-0002", "Rear glass cracked after a fall from a table.", 9 },
                    { 3, "Pressure marks near one corner, no case.", 3, null, new DateTime(2026, 9, 20, 9, 30, 0, 0, DateTimeKind.Unspecified), 1, "FF-2026-0003", "A dark patch is spreading from one corner of the screen.", 10 },
                    { 4, "Burn smell near the charging port, otherwise clean.", 4, null, new DateTime(2026, 9, 28, 16, 5, 0, 0, DateTimeKind.Unspecified), 4, "FF-2026-0004", "Laptop does not power on after a power surge.", 11 },
                    { 5, "Dent on the bottom case corner, charger included.", 5, null, new DateTime(2026, 9, 30, 11, 20, 0, 0, DateTimeKind.Unspecified), 1, "FF-2026-0005", "Slow start-up and frequent freezing during video calls.", 12 },
                    { 6, "Good condition, dust buildup around the vents.", 6, new DateOnly(2026, 10, 18), new DateTime(2026, 10, 1, 10, 0, 0, 0, DateTimeKind.Unspecified), 3, "FF-2026-0006", "Fan runs loudly and the computer shuts down under load.", 6 },
                    { 7, "Scuffed bezel, strap worn at the clasp.", 7, new DateOnly(2026, 10, 15), new DateTime(2026, 10, 2, 15, 10, 0, 0, DateTimeKind.Unspecified), 2, "FF-2026-0007", "Watch will not charge and the screen stays black.", 8 },
                    { 8, "Scratched back glass, otherwise good.", 8, new DateOnly(2026, 10, 26), new DateTime(2026, 10, 7, 12, 25, 0, 0, DateTimeKind.Unspecified), 2, "FF-2026-0008", "Rear camera is blurry and rattles when the phone is shaken.", 7 },
                    { 9, "Clean screen, small scratch on the back near the camera.", 9, new DateOnly(2026, 11, 6), new DateTime(2026, 10, 9, 9, 45, 0, 0, DateTimeKind.Unspecified), 2, "FF-2026-0009", "Charging port is loose and the phone only charges at certain angles.", 5 },
                    { 10, "Pressure marks near one corner, case missing.", 10, new DateOnly(2026, 10, 31), new DateTime(2026, 10, 14, 13, 30, 0, 0, DateTimeKind.Unspecified), 3, "FF-2026-0010", "Display flickers and shows horizontal lines after waking from sleep.", 4 },
                    { 11, "Minor scratches on the lid, no visible liquid damage.", 11, new DateOnly(2026, 10, 30), new DateTime(2026, 10, 16, 10, 50, 0, 0, DateTimeKind.Unspecified), 2, "FF-2026-0011", "Keyboard keys stick and some letters do not register.", 3 },
                    { 12, "Heavy wear, missing rubber feet.", 12, null, new DateTime(2026, 10, 21, 17, 0, 0, 0, DateTimeKind.Unspecified), 2, "FF-2026-0012", "Battery drains within an hour and the laptop shuts down without warning.", 2 },
                    { 13, "Cracked glass across the lower third, light scuffs on the frame.", 1, null, new DateTime(2026, 10, 23, 9, 15, 0, 0, DateTimeKind.Unspecified), 2, "FF-2026-0013", "Screen cracked after a drop and touch is unresponsive in the lower half.", 1 },
                    { 14, "Light wear, small dent on the top-left corner.", 2, new DateOnly(2026, 11, 2), new DateTime(2026, 10, 24, 11, 35, 0, 0, DateTimeKind.Unspecified), 1, "FF-2026-0014", "Speaker sounds muffled and callers cannot be heard clearly.", 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "RepairTickets",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DeviceTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Devices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DeviceModels",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DeviceTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DeviceTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DeviceTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DeviceTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DeviceTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
