namespace Business.Request.Brand
{
    public class AddBrandRequest
    {//Dto
        //Brande ekleme yapmak için bunu oluşturduk, burdan kontrol ederek ekleyecek. response ile geri dönüş yapacak.
        public string Name { get; set; }
        public AddBrandRequest(string name)
        {
            Name = name;
        }
    }
}
