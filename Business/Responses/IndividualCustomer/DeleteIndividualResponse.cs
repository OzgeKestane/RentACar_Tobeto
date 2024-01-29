namespace Business.Responses.IndividualCustomer
{
    public class DeleteIndividualResponse
    {
        public DeleteIndividualResponse(int ıd, string firstName, string lastName, int nationalIdentity, DateTime deletedAt)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            DeletedAt = deletedAt;
        }
        public DeleteIndividualResponse()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalIdentity { get; set; }
        public DateTime DeletedAt { get; set; }

    }
}
