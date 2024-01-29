namespace Business.Responses.CorporateCustomer
{
    public class AddCorporateResponse
    {
        public AddCorporateResponse(int ıd, string companyName, int taxNo, DateTime createdAt)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            CreatedAt = createdAt;
        }
        public AddCorporateResponse()
        {

        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
