namespace Fixel.ViewModels.RepairTickets.Form
{
    public class TicketDeviceOptionViewModel
    {
        public int Id { get; set; }

        public string ManufacturerName { get; set; } = null!;

        public string ModelName { get; set; } = null!;

        public string? SerialNumber { get; set; }

        public string? CustomerFirstName { get; set; }

        public string? CustomerLastName { get; set; }

        public override string ToString()
        {
            return CustomerFirstName is not null
                ? $"{ManufacturerName} {ModelName} ({CustomerFirstName} {CustomerLastName})"
                : $"{ManufacturerName} {ModelName}";
        }
    }
}