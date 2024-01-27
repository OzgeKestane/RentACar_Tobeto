namespace Business.Responses.Model
{
    public class AddModelResponse
    {
        //Id, BrandId, FuelId, TransmissionId, Name, DailyPrice
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public decimal DailyPrice { get; set; }
        public short Year { get; set; }
        public DateTime CreatedAt { get; set; }
        public AddModelResponse(int id, string name, int brandId, int fuelId, int transmissionId, decimal dailyPrice, short year, DateTime createdAt)
        {
            Id = id;
            Name = name;
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            DailyPrice = dailyPrice;
            CreatedAt = createdAt;
            Year = year;
        }
        public AddModelResponse()
        {

        }
    }
}
