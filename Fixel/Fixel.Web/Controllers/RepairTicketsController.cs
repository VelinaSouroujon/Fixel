using Fixel.Core.Devices;
using Fixel.Core.RepairTickets;
using Fixel.Core.RepairTickets.Exceptions;
using Fixel.ViewModels.RepairTickets.Details;
using Fixel.ViewModels.RepairTickets.Form;
using Fixel.ViewModels.RepairTickets.Index;
using Microsoft.AspNetCore.Mvc;

namespace Fixel.Web.Controllers
{
    public class RepairTicketsController : Controller
    {
        private readonly IRepairTicketService _repairTicketService;
        private readonly IDeviceService _deviceService;

        public RepairTicketsController(IRepairTicketService repairTicketService,
            IDeviceService deviceService)
        {
            _repairTicketService = repairTicketService;
            _deviceService = deviceService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<TicketIndexViewModel> tickets = await _repairTicketService.GetAllTicketsAsync();

            return View(tickets);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            TicketDetailsViewModel? ticketDetails = await _repairTicketService.DetailsAsync(id);

            if (ticketDetails is null)
            {
                return NotFound();
            }

            return View(ticketDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            TicketFormModel model = new TicketFormModel
            {
                Devices = await _deviceService.GetDeviceOptionsAsync()
            };


            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(TicketFormModel model)
        {
            if (!ModelState.IsValid)
            {
                model.Devices = await _deviceService.GetDeviceOptionsAsync();

                return View(model);
            }

            try
            {
                await _repairTicketService.CreateAsync(model);
            }
            catch (DuplicateReferenceNumberException)
            {
                ModelState.AddModelError(nameof(model.ReferenceNumber), "Reference number is already taken");
                model.Devices = await _deviceService.GetDeviceOptionsAsync();

                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
