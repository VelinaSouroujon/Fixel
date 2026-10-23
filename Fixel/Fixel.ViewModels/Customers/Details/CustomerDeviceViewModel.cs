namespace Fixel.ViewModels.Customers.Details
{
    public class CustomerDeviceViewModel
    {
        public int Id { get; set; }

        public string DeviceModel { get; set; } = null!;

        public string DeviceType { get; set; } = null!;

        public string? SerialNumber { get; set; }
    }
}
