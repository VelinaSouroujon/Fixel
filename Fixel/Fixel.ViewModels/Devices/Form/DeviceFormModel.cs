using System.ComponentModel.DataAnnotations;
using Fixel.ViewModels.Customers.Search;
using Fixel.ViewModels.DeviceModels.Search;

using static Fixel.Common.Constants.Validation.DeviceConstants;
using static Fixel.Common.Constants.ApplicationConstants;

namespace Fixel.ViewModels.Devices.Form
{
    public class DeviceFormModel
    {
        [Required(ErrorMessage = "Please select a device model")]
        public int? DeviceModelId { get; set; }

        [Required(ErrorMessage = "Please select an owner")]
        public int? CustomerId { get; set; }

        [MinLength(SerialNumberMinLength)]
        [MaxLength(SerialNumberMaxLength)]
        public string? SerialNumber { get; set; }

        public CustomerSearchResultViewModel? SelectedCustomer { get; set; }

        public IEnumerable<DeviceModelOptionViewModel> DeviceModels { get; set; } = new List<DeviceModelOptionViewModel>();

        public int DropdownLimitDeviceModels { get; set; } = DropdownSuggestionsDefaultLimit;
    }
}
