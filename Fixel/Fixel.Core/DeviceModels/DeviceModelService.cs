using Fixel.Data;
using Fixel.ViewModels.DeviceModels.Search;
using Microsoft.EntityFrameworkCore;

namespace Fixel.Core.DeviceModels
{
    public class DeviceModelService : IDeviceModelService
    {
        private readonly AppDbContext _context;

        public DeviceModelService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<DeviceModelOptionViewModel>> GetAllModelOptionsAsync()
        {
            return await _context.DeviceModels.Select(dm => new DeviceModelOptionViewModel
                {
                    Id = dm.Id,
                    DeviceType = dm.DeviceType.TypeName,
                    ManufacturerName = dm.Manufacturer.Name,
                    ModelName = dm.Name,
                })
                .ToListAsync();
        }
    }
}
