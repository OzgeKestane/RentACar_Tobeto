namespace Business.Responses.IndividualCustomer
{
    public class GetIndividualByIdResponse
    {
        public GetIndividualByIdResponse(int ıd, string firstName, string lastName, int nationalIDentity)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIDentity = nationalIDentity;
        }
        public GetIndividualByIdResponse()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalIDentity { get; set; }
    }
}
