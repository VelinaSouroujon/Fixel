using EntityFramework.Exceptions.Common;
using Fixel.Core.RepairTickets.Exceptions;
using Fixel.Data;
using Fixel.Data.Models;
using Fixel.ViewModels.RepairTickets.Details;
using Fixel.ViewModels.RepairTickets.Form;
using Fixel.ViewModels.RepairTickets.Index;
using Microsoft.EntityFrameworkCore;

namespace Fixel.Core.RepairTickets
{
    public class RepairTicketService : IRepairTicketService
    {
        private static readonly HashSet<RepairStatus> InactiveStatuses = new HashSet<RepairStatus>
        {
            RepairStatus.Collected,
            RepairStatus.ReadyForCollection,
            RepairStatus.Declined,
            RepairStatus.Unrepairable,
            RepairStatus.Cancelled
        };

        private readonly AppDbContext _context;

        public RepairTicketService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TicketIndexViewModel>> GetAllTicketsAsync()
        {
            List<TicketIndexViewModel> allTickets = await _context.RepairTickets
                .AsNoTracking()
                .OrderByDescending(rt => rt.IntakeDate)
                .Select(rt => new TicketIndexViewModel
                {
                    Id = rt.Id,
                    ReferenceNumber = rt.ReferenceNumber,
                    CustomerFirstName = rt.Device.Customer!.FirstName,
                    CustomerLastName = rt.Device.Customer.LastName,
                    DeviceManufacturerName = rt.Device.Model.Manufacturer.Name,
                    DeviceModelName = rt.Device.Model.Name,
                    ExpectedCompletionDate = rt.ExpectedCompletionDate,
                    Priority = rt.Priority,
                    Status = rt.Status,
                })
                .ToListAsync();

            allTickets.ForEach(t =>
                t.IsOverdue = IsTicketOverdue(t.ExpectedCompletionDate, t.Status));

            return allTickets;
        }

        public async Task<TicketDetailsViewModel?> DetailsAsync(int id)
        {
            TicketDetailsViewModel? ticketDetails = await _context.RepairTickets
                .Where(rt => rt.Id == id)
                .Select(rt => new TicketDetailsViewModel
                {
                    Id = rt.Id,
                    Priority = rt.Priority,
                    ReportedProblem = rt.ReportedProblem,
                    ReferenceNumber = rt.ReferenceNumber,
                    ExpectedCompletionDate = rt.ExpectedCompletionDate,
                    Status = rt.Status,
                    ConditionDescription = rt.ConditionDescription,
                    CustomerId = rt.Device.CustomerId,
                    CustomerFirstName = rt.Device.Customer!.FirstName,
                    CustomerLastName = rt.Device.Customer.LastName,
                    CustomerPhoneNumber = rt.Device.Customer.PhoneNumber,
                    DeviceId = rt.DeviceId,
                    DeviceManufacturerName = rt.Device.Model.Manufacturer.Name,
                    DeviceModelName = rt.Device.Model.Name,
                    DeviceSerialNumber = rt.Device.SerialNumber,
                    DeviceType = rt.Device.Model.DeviceType.TypeName,
                    IntakeDate = rt.IntakeDate
                })
                .FirstOrDefaultAsync();

            if (ticketDetails is not null)
            {
                ticketDetails.IsOverdue = IsTicketOverdue(ticketDetails.ExpectedCompletionDate, ticketDetails.Status);
            }

            return ticketDetails;
        }

        public async Task CreateAsync(TicketFormModel model)
        {
            ArgumentNullException.ThrowIfNull(model);

            RepairTicket repairTicket = new RepairTicket
            {
                ReferenceNumber = model.ReferenceNumber,
                DeviceId = model.DeviceId,
                ConditionDescription = model.ConditionDescription,
                ExpectedCompletionDate = model.ExpectedCompletionDate,
                IntakeDate = DateTime.UtcNow,
                Priority = model.Priority,
                ReportedProblem = model.ReportedProblem,
                Status = RepairStatus.Received,
            };

            _context.Add(repairTicket);

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (UniqueConstraintException ex)
            {
                if (ex.ConstraintProperties.Contains(nameof(RepairTicket.ReferenceNumber)))
                {
                    throw new DuplicateReferenceNumberException("Reference number already exists", ex);
                }

                throw;
            }
        }

        public bool IsTicketOverdue(DateOnly? expectedCompletionDate, RepairStatus status)
        {
            return expectedCompletionDate is not null
                   && (!InactiveStatuses.Contains(status))
                   && DateOnly.FromDateTime(DateTime.UtcNow) > expectedCompletionDate;
        }
    }
}
