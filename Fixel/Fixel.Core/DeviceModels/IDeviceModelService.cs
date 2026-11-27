using Fixel.ViewModels.DeviceModels.Search;

namespace Fixel.Core.DeviceModels
{
    public interface IDeviceModelService
    {
        Task<IEnumerable<DeviceModelOptionViewModel>> GetAllModelOptionsAsync();
    }
}
