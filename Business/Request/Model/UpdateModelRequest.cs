namespace Business.Request.Model
{
    public class UpdateModelRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public decimal DailyPrice { get; set; }
        public short Year { get; set; }
        public UpdateModelRequest(int id, string name, int brandId, int fuelId, int transmissionId, decimal dailyPrice, short year)
        {
            Id = id;
            Name = name;
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            DailyPrice = dailyPrice;
            Year = year;
        }
    }
}
