namespace Business.Request.Brand
{
    public class UpdateBrandRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public UpdateBrandRequest(string name, int ıd)
        {
            Name = name;
            Id = ıd;
        }
    }
}
