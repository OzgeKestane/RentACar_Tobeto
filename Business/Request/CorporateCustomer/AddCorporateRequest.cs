namespace Business.Request.CorporateCustomer
{
    public class AddCorporateRequest
    {
        public AddCorporateRequest(string companyName, int taxNo)
        {
            CompanyName = companyName;
            TaxNo = taxNo;
        }

        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
    }
}
