using Fixel.Data.Models;
using Fixel.ViewModels.RepairTickets.Details;
using Fixel.ViewModels.RepairTickets.Form;
using Fixel.ViewModels.RepairTickets.Index;

namespace Fixel.Core.RepairTickets
{
    public interface IRepairTicketService
    {
        Task<IEnumerable<TicketIndexViewModel>> GetAllTicketsAsync();

        Task<TicketDetailsViewModel?> DetailsAsync(int id);

        Task CreateAsync(TicketFormModel model);

        bool IsTicketOverdue(DateOnly? expectedCompletionDate, RepairStatus status);
    }
}
