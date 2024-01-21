namespace Business.Request.Brand
{
    public class UpdateBrandRequest
    {
        public string Name { get; set; }
        public UpdateBrandRequest(string name)
        {
            Name = name;
        }
    }
}
