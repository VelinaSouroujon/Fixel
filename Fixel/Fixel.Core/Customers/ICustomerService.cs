using Fixel.ViewModels.Customers;

namespace Fixel.Core.Customers
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerIndexViewModel>> GetAllCustomersAsync();
    }
}
