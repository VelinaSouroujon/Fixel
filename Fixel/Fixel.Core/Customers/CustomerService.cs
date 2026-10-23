using Fixel.Data;
using Fixel.Data.Models;
using Fixel.ViewModels.Customers.Details;
using Fixel.ViewModels.Customers.Index;
using Microsoft.EntityFrameworkCore;

namespace Fixel.Core.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly AppDbContext _context;

        public CustomerService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CustomerIndexViewModel>> GetAllCustomersAsync()
        {
            return await _context.Customers
                .AsNoTracking()
                .OrderBy(c => c.FirstName)
                .ThenBy(c => c.LastName)
                .Select(c => new CustomerIndexViewModel
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,

                    ActiveTicketsCount = c.Devices
                        .SelectMany(d => d.RepairTickets)
                        .Count(rt => rt.Status != RepairStatus.Collected)
                })
                .ToListAsync();
        }

        public async Task<CustomerDetailsViewModel?> GetDetailsAsync(int id)
        {
            return await _context.Customers
                .AsNoTracking()
                .Where(c => c.Id == id)
                .Select(c => new CustomerDetailsViewModel
                {
                    Id = c.Id,
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                    PhoneNumber = c.PhoneNumber,
                    Email = c.Email,
                    PreferredContactMethod = c.PreferredContactMethod,

                    Devices = c.Devices.Select(d => new CustomerDeviceViewModel
                    {
                        Id = d.Id,
                        DeviceType = d.Model.DeviceType.TypeName,
                        DeviceModel = d.Model.Name,
                        SerialNumber = d.SerialNumber
                    })
                    .ToList(),

                    RepairTickets = c.Devices
                        .SelectMany(d => d.RepairTickets)
                        .OrderBy(rt => rt.Status == RepairStatus.Collected ? 1 : 0)
                        .ThenByDescending(rt => rt.IntakeDate)
                        .Select(rt => new CustomerTicketViewModel
                        {
                            Id = rt.Id,
                            DeviceModelName = rt.Device.Model.Name,
                            DeviceManufacturerName = rt.Device.Model.Manufacturer.Name,
                            ReferenceNumber = rt.ReferenceNumber,
                            IntakeDate = rt.IntakeDate,
                            RepairStatus = rt.Status
                        })
                        .ToList()
                })
                .FirstOrDefaultAsync();
        }
    }
}
