using Core.Entities;

namespace Entities.Concrete
{
    public class IndividualCustomer : Entity<int>
    {
        public IndividualCustomer(string firstName, string lastName, int nationalIdentity)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
        }
        public IndividualCustomer()
        {

        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalIdentity { get; set; }
    }
}
