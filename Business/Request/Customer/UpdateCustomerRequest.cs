namespace Business.Request.Customer
{
    public class UpdateCustomerRequest
    {
        public UpdateCustomerRequest(int userId, int ıd)
        {
            UserId = userId;
            Id = ıd;
        }
        public UpdateCustomerRequest()
        {

        }
        public int Id { get; set; }
        public int UserId { get; set; }

    }
}
