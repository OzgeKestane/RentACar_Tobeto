namespace Business.Responses.Model
{
    public class UpdateModelResponse
    {//Id, BrandId, FuelId, TransmissionId, Name, DailyPrice


        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public decimal DailyPrice { get; set; }
        public short Year { get; set; }
        public DateTime UpdatedAt { get; set; }
        public UpdateModelResponse(int ıd, string name, int brandId, int fuelId, int transmissionId, decimal dailyPrice, DateTime updatedAt, short year)
        {
            Id = ıd;
            Name = name;
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            DailyPrice = dailyPrice;
            UpdatedAt = updatedAt;
            Year = year;
        }
        public UpdateModelResponse()
        {

        }

    }
}
