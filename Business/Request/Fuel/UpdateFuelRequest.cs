namespace Business.Request.Fuel
{
    public class UpdateFuelRequest
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public UpdateFuelRequest(string name, int ıd)
        {
            Name = name;
            Id = ıd;

        }
    }
}
