namespace Business.Responses.CorporateCustomer
{
    public class DeleteCorporateResponse
    {
        public DeleteCorporateResponse(int ıd, string companyName, int taxNo, DateTime deletedAt)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
            DeletedAt = deletedAt;
        }
        public DeleteCorporateResponse()
        {

        }

        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
