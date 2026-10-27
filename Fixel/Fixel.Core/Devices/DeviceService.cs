using Fixel.Data;
using Fixel.ViewModels.RepairTickets.Form;
using Microsoft.EntityFrameworkCore;

namespace Fixel.Core.Devices
{
    public class DeviceService : IDeviceService
    {
        private readonly AppDbContext _context;

        public DeviceService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TicketDeviceOptionViewModel>> GetDeviceOptionsAsync()
        {
            return await _context.Devices
                .Select(d => new TicketDeviceOptionViewModel
                {
                    Id = d.Id,
                    ManufacturerName = d.Model.Manufacturer.Name,
                    ModelName = d.Model.Name,
                    SerialNumber = d.SerialNumber,
                    CustomerFirstName = d.Customer!.FirstName,
                    CustomerLastName = d.Customer.LastName,
                })
                .ToListAsync();
        }
    }
}
