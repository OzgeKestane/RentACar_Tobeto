namespace Business.Responses.CorporateCustomer
{
    public class GetCorporateByIdResponse
    {
        public GetCorporateByIdResponse(int ıd, string companyName, int taxNo)
        {
            Id = ıd;
            CompanyName = companyName;
            TaxNo = taxNo;
        }
        public GetCorporateByIdResponse()
        {

        }
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public int TaxNo { get; set; }
    }
}
