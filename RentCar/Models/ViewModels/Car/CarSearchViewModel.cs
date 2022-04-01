using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RentCar.Models.ViewModels.Car
{
    public class CarSearchViewModel
    {
        public string CarBrand { get; set; }
        public string CarModel { get; set; }
        public string City { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float MinPrice { get; set; }
        public float MaxPrice { get; set; }
    }
}
