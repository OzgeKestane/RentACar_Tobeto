namespace Business.Request.Car
{
    public class AddCarRequest
    {
        public AddCarRequest(int colorId, int modelId, string carState, int kilometer, string plate)
        {
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;

            Plate = plate;
        }

        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }

        public string Plate { get; set; }

    }
}
