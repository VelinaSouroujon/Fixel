using Fixel.Core.Customers;
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

        public async Task<IActionResult> Index()
        {
            IEnumerable<CustomerIndexViewModel> customers =  await _customerService.GetAllCustomersAsync();

            return View(customers);
        }

        public async Task<IActionResult> Details(int id)
        {
            CustomerDetailsViewModel? customerDetails = await _customerService.GetDetailsAsync(id);

            if (customerDetails is null)
            {
                return NotFound();
            }

            return View(customerDetails);
        }
    }
}
