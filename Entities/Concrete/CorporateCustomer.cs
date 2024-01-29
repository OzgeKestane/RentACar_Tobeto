using Core.Entities;

namespace Entities.Concrete
{
    public class CorporateCustomer : Entity<int>
    {
        public CorporateCustomer(string companyName, int taxNo)
        {
            CompanyName = companyName;
            TaxNo = taxNo;
        }
        public CorporateCustomer()
        {

        }

        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
    }
}
