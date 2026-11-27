using Fixel.ViewModels.Common;

namespace Fixel.ViewModels.Customers.Search
{
    public class CustomerSearchResultViewModel : ISearchOptionViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string PrimaryText => $"{FirstName} {LastName}";

        public string SecondaryText => PhoneNumber;

        public string DisplayText => $"{FirstName} {LastName} ({PhoneNumber})";
    }
}
