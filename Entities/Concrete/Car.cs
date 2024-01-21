using Core.Entities;

namespace Entities.Concrete
{
    public class Car : Entity<int>
    {
        //Id, ColorId, ModelId, CarState, Kilometer, ModelYear, Plate
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public int ModelYear { get; set; }
        public string Plate { get; set; }
        public Car()
        {

        }

        public Car(int colorId, int modelId, string carState, int kilometer, int modelYear, string plate)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            ModelYear = modelYear;
            Plate = plate;
        }
    }
}
