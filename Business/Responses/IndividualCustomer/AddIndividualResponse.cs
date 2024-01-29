namespace Business.Responses.IndividualCustomer
{
    public class AddIndividualResponse
    {
        public AddIndividualResponse(int ıd, string firstName, string lastName, int nationalIdentity, DateTime createdAt)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            CreatedAt = createdAt;
        }
        public AddIndividualResponse()
        {

        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalIdentity { get; set; }
        public DateTime CreatedAt { get; set; }

    }
}
