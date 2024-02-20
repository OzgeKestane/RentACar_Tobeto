namespace Business.Request.Transmission
{
    public class UpdateTransmissionRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UpdateTransmissionRequest(string name, int ıd)
        {
            Name = name;
            Id = ıd;
        }
        public UpdateTransmissionRequest()
        {

        }
    }
}
