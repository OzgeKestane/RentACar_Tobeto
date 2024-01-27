namespace Business.Responses.Model
{
    public class DeleteModelResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public decimal DailyPrice { get; set; }
        public short Year { get; set; }
        public DateTime DeletedAt { get; set; }
        public DeleteModelResponse(int ıd, string name, int brandId, int fuelId, int transmissionId, decimal dailyPrice, DateTime deletedAt, short year)
        {
            Id = ıd;
            Name = name;
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            DailyPrice = dailyPrice;
            DeletedAt = deletedAt;
            Year = year;
        }
        public DeleteModelResponse()
        {

        }
    }
}
