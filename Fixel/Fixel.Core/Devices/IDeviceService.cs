using Fixel.ViewModels.Devices.Details;
using Fixel.ViewModels.Devices.Form;
using Fixel.ViewModels.Devices.Index;
using Fixel.ViewModels.Devices.Search;

namespace Fixel.Core.Devices
{
    public interface IDeviceService
    {
        Task<IEnumerable<DeviceIndexViewModel>> GetAllDevicesAsync();

        Task<DeviceDetailsViewModel?> DetailsAsync(int id);

        Task<IEnumerable<DeviceOptionViewModel>> GetDeviceOptionsAsync();

        Task CreateAsync(DeviceFormModel model);
    }
}
