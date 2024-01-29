namespace Business.Request.CorporateCustomer
{
    public class UpdateCorporateRequest
    {
        public UpdateCorporateRequest(int ıd, string companyName, int taxNo)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
    }
}
