using Fixel.ViewModels.Customers.Create;
using Fixel.ViewModels.Customers.Details;
using Fixel.ViewModels.Customers.Index;

namespace Fixel.Core.Customers
{
    public interface ICustomerService
    {
        Task<IEnumerable<CustomerIndexViewModel>> GetAllCustomersAsync();

        Task<CustomerDetailsViewModel?> GetDetailsAsync(int id);

        Task CreateAsync(CreateCustomerFormModel model);
    }
}
