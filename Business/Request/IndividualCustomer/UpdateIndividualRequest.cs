namespace Business.Request.IndividualCustomer
{
    public class UpdateIndividualRequest
    {
        public UpdateIndividualRequest(int ıd, string firstName, string lastName, int nationalIdentity)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalIdentity { get; set; }
    }
}
