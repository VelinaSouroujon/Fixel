using Fixel.Core.Customers;
using Fixel.Core.Customers.Exceptions;
using Fixel.ViewModels.Customers.Create;
using Fixel.ViewModels.Customers.Details;
using Fixel.ViewModels.Customers.Index;
using Microsoft.AspNetCore.Mvc;

namespace Fixel.Web.Controllers
{
    public class CustomersController : Controller
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            IEnumerable<CustomerIndexViewModel> customers =  await _customerService.GetAllCustomersAsync();

            return View(customers);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            CustomerDetailsViewModel? customerDetails = await _customerService.GetDetailsAsync(id);

            if (customerDetails is null)
            {
                return NotFound();
            }

            return View(customerDetails);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCustomerFormModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            try
            {
                await _customerService.CreateAsync(model);
            }
            catch (DuplicateEmailException)
            {
                ModelState.AddModelError(nameof(model.Email), "Email address is already taken");
                return View(model);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
