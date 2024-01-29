namespace Business.Responses.Car
{
    public class AddCarResponse
    {
        public AddCarResponse(int ıd, int colorId, int modelId, string carState, int kilometer, string plate, DateTime createdAt)
        {
            Id = ıd;
            ColorId = colorId;
            ModelId = modelId;
            CarState = carState;
            Kilometer = kilometer;
            Plate = plate;
            CreatedAt = createdAt;
        }

        public int Id { get; set; }
        public int ColorId { get; set; }
        public int ModelId { get; set; }
        public string CarState { get; set; }
        public int Kilometer { get; set; }
        public string Plate { get; set; }
        public DateTime CreatedAt { get; set; }
        public AddCarResponse()
        {

        }
    }
}
