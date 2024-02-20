namespace Business.Request.Fuel
{
    public class UpdateFuelRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UpdateFuelRequest(string name, int id)
        {
            Name = name;
            Id = id;
        }
        public UpdateFuelRequest()
        {

        }
    }
}
