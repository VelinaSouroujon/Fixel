using Fixel.ViewModels.Customers;
using Fixel.ViewModels.Customers.Details;
using Fixel.ViewModels.Customers.Index;

namespace Fixel.Core.Customers
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerIndexViewModel>> GetAllCustomersAsync();

        Task<CustomerDetailsViewModel?> GetDetailsAsync(int id);

        Task CreateAsync(CustomerFormModel model);

        Task<CustomerFormModel?> GetProfileInfoAsync(int id);

        Task UpdateAsync(int id, CustomerFormModel model);
    }
}
