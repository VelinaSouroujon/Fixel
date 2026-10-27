using Fixel.ViewModels.RepairTickets.Form;

namespace Fixel.Core.Devices
{
    public interface IDeviceService
    {
        Task<IEnumerable<TicketDeviceOptionViewModel>> GetDeviceOptionsAsync();
    }
}
