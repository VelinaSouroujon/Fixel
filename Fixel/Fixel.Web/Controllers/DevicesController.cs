using Fixel.Core.DeviceModels;
using Fixel.Core.Devices;
using Fixel.Core.Devices.Exceptions;
using Fixel.ViewModels.Devices.Details;
using Fixel.ViewModels.Devices.Form;
using Fixel.ViewModels.Devices.Index;
using Microsoft.AspNetCore.Mvc;

namespace Fixel.Web.Controllers
{
    public class DevicesController : Controller
    {
        private readonly IDeviceService _deviceService;
        private readonly IDeviceModelService _deviceModelService;

        public DevicesController(
            IDeviceService deviceService,
            IDeviceModelService deviceModelService)
        {
            _deviceService = deviceService;
            _deviceModelService = deviceModelService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<DeviceIndexViewModel> devices = await _deviceService.GetAllDevicesAsync();

            return View(devices);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            DeviceDetailsViewModel? deviceDetails = await _deviceService.DetailsAsync(id);

            if (deviceDetails is null)
            {
                return NotFound();
            }

            return View(deviceDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            DeviceFormModel model = new();
            await AddDeviceModelsAsync(model);

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(DeviceFormModel model)
        {
            if (!ModelState.IsValid)
            {
                await AddDeviceModelsAsync(model);
                return View(model);
            }

            try
            {
                await _deviceService.CreateAsync(model);
            }
            catch (DuplicateSerialNumberException)
            {
                ModelState.AddModelError(nameof(model.SerialNumber), "Serial number is already taken");
                await AddDeviceModelsAsync(model);

                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }

        private async Task AddDeviceModelsAsync(DeviceFormModel model)
        {
            model.DeviceModels = await _deviceModelService.GetAllModelOptionsAsync();
        }
    }
}
