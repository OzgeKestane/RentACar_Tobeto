using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : Entity<int>
    {
        public Customer(int userId)
        {
            UserId = userId;
        }
        public Customer()
        {

        }

        public int UserId { get; set; }
        public User? User { get; set; } = null;
        public ICollection<IndividualCustomer>? IndividualCustomers { get; set; } = null;
        public ICollection<CorporateCustomer>? CorporateCustomers { get; set; } = null;

    }
}
