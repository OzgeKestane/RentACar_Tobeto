﻿namespace Business.Request.Brand
{
    public class AddBrandRequest
    {//Dto
        public string Name { get; set; }
        public AddBrandRequest(string name)
        {
            Name = name;
        }
    }
}
