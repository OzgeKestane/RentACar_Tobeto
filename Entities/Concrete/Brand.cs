using Core.Entities;

namespace Entities.Concrete
{
    //marka
    //internal dediğimizde sadece kendi projesi içinde erişiliyor, public olunca tüm solution içindeki projelerden erişim sağlanabiliyor.
    public class Brand : Entity<int>
    {
        //Entityden alacak Id'yi burada yazmaya gerek yok
        //public int Id { get; set; }
        public string Name { get; set; }
        public string LogoUrl { get; set; }
        public bool Premium { get; set; }
        public double Rating { get; set; }
        public Brand()
        {

        }
        public Brand(string name, string logoUrl, bool premium, double rating)
        {
            Name = name;
            LogoUrl = logoUrl;
            Premium = premium;
            Rating = rating;
        }
        //public ICollection<Model>? Models { get; set; } = null;
    }
}
