namespace Business.Responses.IndividualCustomer
{
    public class UpdateIndividualResponse
    {
        public UpdateIndividualResponse(int ıd, string firstName, string lastName, int nationalIdentity, DateTime updatedAt)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
            UpdatedAt = updatedAt;
        }
        public UpdateIndividualResponse()
        {

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalIdentity { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
