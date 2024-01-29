using Core.Entities;

namespace Entities.Concrete
{
    public class Model : Entity<int>
    {
        //public int Id { get; set; }
        public int BrandId { get; set; } //normalizasyon
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public short Year { get; set; }
        public string Name { get; set; }
        public decimal DailyPrice { get; set; }
        //public Brand Brand { get; set; } = null!;
        //ünlem burada null olma uyarısını devre dışı bırakmış oluyor

        //public Brand? Brand { get; set; } = null;
        public Model()
        {

        }
        public Model(int brandid, int fuelid, int transmissionid, string name, decimal dailyPrice)
        {
            BrandId = brandid;
            FuelId = fuelid;
            TransmissionId = transmissionid;
            Name = name;
            DailyPrice = dailyPrice;
        }
        //lazy loading
        public Brand? Brand { get; set; } = null; // one-to-one ilişki 
        public Transmission? Transmission { get; set; } = null;
        public Fuel? Fuel { get; set; } = null;
        //bu modelde hangi araçlar var kısmı
        //model ile car arasında one-to-many ilişkisi var
        public ICollection<Car>? Cars { get; set; } = null;
    }
}
