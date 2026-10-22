using Fixel.Data;
using Fixel.Data.Models;
using Fixel.ViewModels.Customers;
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
                    FullName = c.FirstName + " " + c.LastName,
                    Email = c.Email,
                    PhoneNumber = c.PhoneNumber,

                    ActiveTicketsCount = c.Devices
                        .SelectMany(d => d.RepairTickets)
                        .Count(rt => rt.Status != Status.Collected)
                })
                .ToListAsync();
        }
    }
}
