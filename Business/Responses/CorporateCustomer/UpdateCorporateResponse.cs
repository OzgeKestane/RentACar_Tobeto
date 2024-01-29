namespace Business.Responses.CorporateCustomer
{
    public class UpdateCorporateResponse
    {
        public UpdateCorporateResponse(int ıd, string companyName, int taxNo, DateTime updatedAt)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            UpdatedAt = updatedAt;
        }
        public UpdateCorporateResponse()
        {

        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
