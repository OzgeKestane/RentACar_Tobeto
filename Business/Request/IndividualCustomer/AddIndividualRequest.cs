namespace Business.Request.IndividualCustomer
{
    public class AddIndividualRequest
    {
        public AddIndividualRequest(string firstName, string lastName, int nationalIdentity)
        {
            FirstName = firstName;
            LastName = lastName;
            NationalIdentity = nationalIdentity;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int NationalIdentity { get; set; }
    }
}
