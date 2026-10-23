namespace Fixel.ViewModels.Customers.Index
{
    public class CustomerIndexViewModel
    {
        public int Id { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string PhoneNumber { get; set; } = null!;

        public string? Email { get; set; }

        public int ActiveTicketsCount { get; set; }
    }
}
