﻿namespace Business.Request.Model
{
    public class AddModelRequest
    {
        // BrandId, FuelId, TransmissionId, Name, DailyPrice
        public string Name { get; set; }
        public int BrandId { get; set; }
        public int FuelId { get; set; }
        public int TransmissionId { get; set; }
        public decimal DailyPrice { get; set; }
        public AddModelRequest(string name, int brandId, int fuelId, int transmissionId, decimal dailyPrice)
        {
            Name = name;
            BrandId = brandId;
            FuelId = fuelId;
            TransmissionId = transmissionId;
            DailyPrice = dailyPrice;

        }

    }
}
