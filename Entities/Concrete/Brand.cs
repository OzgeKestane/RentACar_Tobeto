using Core.Entities;

namespace Entities.Concrete
{
    //marka
    //internal dediğimizde sadece kendi projesi içinde erişiliyor, public olunca tüm solution içindeki projelerden erişim sağlanabiliyor.
    public class Brand : Entity<int>
    {
        //Entityden alacak Id'yi burada yazmaya gerek yok
        //public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Brand()
        {

        }
        public Brand(string name)
        {
            Name = name;
        }

    }
}
