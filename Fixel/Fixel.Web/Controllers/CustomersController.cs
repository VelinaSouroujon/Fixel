using Fixel.Core.Customers;
using Fixel.ViewModels.Customers;
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
    }
}
