using EntityFramework.Exceptions.Common;
using Fixel.Core.Devices.Exceptions;
using Fixel.Core.RepairTickets;
using Fixel.Data;
using Fixel.Data.Models;
using Fixel.ViewModels.Devices.Details;
using Fixel.ViewModels.Devices.Form;
using Fixel.ViewModels.Devices.Index;
using Fixel.ViewModels.Devices.Search;
using Microsoft.EntityFrameworkCore;

namespace Fixel.Core.Devices
{
    public class DeviceService : IDeviceService
    {
        private readonly AppDbContext _context;
        private readonly IRepairTicketService _repairTicketService;

        public DeviceService(AppDbContext context, IRepairTicketService repairTicketService)
        {
            _context = context;
            _repairTicketService = repairTicketService;
        }

        public async Task<IEnumerable<DeviceIndexViewModel>> GetAllDevicesAsync()
        {
            IReadOnlyCollection<RepairStatus> inactiveStatuses = _repairTicketService.GetInactiveStatuses();

            return await _context.Devices
                .Select(d => new DeviceIndexViewModel
                {
                    Id = d.Id,
                    DeviceType = d.Model.DeviceType.TypeName,
                    SerialNumber = d.SerialNumber,
                    ModelName = d.Model.Name,
                    TicketsCount = d.RepairTickets.Count,
                    CustomerId = d.CustomerId,
                    CustomerFirstName = d.Customer!.FirstName,
                    CustomerLastName = d.Customer.LastName,
                    ManufacturerName = d.Model.Manufacturer.Name,
                    ActiveTicketsCount = d.RepairTickets.Count(rt => !inactiveStatuses.Contains(rt.Status)),
                })
                .OrderBy(d => d.ManufacturerName)
                .ThenBy(d => d.ModelName)
                .ToListAsync();
        }

        public async Task<DeviceDetailsViewModel?> DetailsAsync(int id)
        {
            DeviceDetailsViewModel? deviceDetails = await _context.Devices
                .Select(d => new DeviceDetailsViewModel
                {
                    Id = d.Id,
                    DeviceType = d.Model.DeviceType.TypeName,
                    ModelName = d.Model.Name,
                    SerialNumber = d.SerialNumber,
                    ManufacturerName = d.Model.Manufacturer.Name,
                    RepairTickets = d.RepairTickets
                        .Select(rt => new DeviceTicketViewModel
                        {
                            Id = rt.Id,
                            Status = rt.Status,
                            ExpectedCompletionDate = rt.ExpectedCompletionDate,
                            IntakeDate = rt.IntakeDate,
                            Priority = rt.Priority,
                            ReferenceNumber = rt.ReferenceNumber,
                            ReportedProblem = rt.ReportedProblem,
                        })
                        .ToList(),
                    CustomerId = d.CustomerId,
                    CustomerFirstName = d.Customer!.FirstName,
                    CustomerLastName = d.Customer.LastName,
                    CustomerEmail = d.Customer.Email,
                    CustomerPhoneNumber = d.Customer.PhoneNumber,
                })
                .FirstOrDefaultAsync(d => d.Id == id);

            if (deviceDetails is null)
            {
                return null;
            }

            foreach (DeviceTicketViewModel ticket in deviceDetails.RepairTickets)
            {
                ticket.IsOverdue = _repairTicketService
                    .IsTicketOverdue(ticket.ExpectedCompletionDate, ticket.Status);
            }

            return deviceDetails;
        }
        public async Task<IEnumerable<DeviceOptionViewModel>> GetDeviceOptionsAsync()
        {
            return await _context.Devices
                .Select(d => new DeviceOptionViewModel
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

        public async Task CreateAsync(DeviceFormModel model)
        {
            ArgumentNullException.ThrowIfNull(model);

            Device device = new()
            {
                ModelId = model.DeviceModelId!.Value,
                CustomerId = model.CustomerId!.Value,
                SerialNumber = model.SerialNumber
            };

            _context.Devices.Add(device);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (UniqueConstraintException ex)
            {
                if (ex.ConstraintProperties.Contains(nameof(Device.SerialNumber)))
                {
                    throw new DuplicateSerialNumberException("Serial number already exists", ex);
                }

                throw;
            }
        }
    }
}
