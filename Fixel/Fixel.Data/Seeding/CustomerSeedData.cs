using Fixel.Data.Models;

namespace Fixel.Data.Seeding
{
    public static class CustomerSeedData
    {
        public static IReadOnlyList<Customer> Customers { get; } = new List<Customer>
        {
            new Customer { Id = 1, FirstName = "Elena", LastName = "Marković", PhoneNumber = "+44 7700 900101", Email = "elena.markovic@example.com", PreferredContactMethod = ContactMethod.Email },
            new Customer { Id = 2, FirstName = "Daniel", LastName = "Okafor", PhoneNumber = "+44 7700 900102", Email = "daniel.okafor@example.com", PreferredContactMethod = ContactMethod.Phone },
            new Customer { Id = 3, FirstName = "Sofia", LastName = "Lindqvist", PhoneNumber = "+44 7700 900103", Email = "sofia.lindqvist@example.com", PreferredContactMethod = ContactMethod.Sms },
            new Customer { Id = 4, FirstName = "Mateo", LastName = "Fernández", PhoneNumber = "+44 7700 900104", Email = null, PreferredContactMethod = ContactMethod.Phone },
            new Customer { Id = 5, FirstName = "Aisha", LastName = "Rahman", PhoneNumber = "+44 7700 900105", Email = "aisha.rahman@example.com", PreferredContactMethod = ContactMethod.Email },
            new Customer { Id = 6, FirstName = "Thomas", LastName = "Becker", PhoneNumber = "+44 7700 900106", Email = "thomas.becker@example.com", PreferredContactMethod = ContactMethod.Sms },
            new Customer { Id = 7, FirstName = "Nina", LastName = "Kowalska", PhoneNumber = "+44 7700 900107", Email = "nina.kowalska@example.com", PreferredContactMethod = ContactMethod.Phone },
            new Customer { Id = 8, FirstName = "Lucas", LastName = "Moreau", PhoneNumber = "+44 7700 900108", Email = null, PreferredContactMethod = ContactMethod.Sms },
            new Customer { Id = 9, FirstName = "Priya", LastName = "Nair", PhoneNumber = "+44 7700 900109", Email = "priya.nair@example.com", PreferredContactMethod = ContactMethod.Email },
            new Customer { Id = 10, FirstName = "Viktor", LastName = "Petrov", PhoneNumber = "+44 7700 900110", Email = "viktor.petrov@example.com", PreferredContactMethod = ContactMethod.Phone }
        }.AsReadOnly();
    }
}
