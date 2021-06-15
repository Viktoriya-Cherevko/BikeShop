using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop.Models
{
    public enum Brand
    {
        Trek,
        Giant,
        Specialized,
        Raleigh
    }
    public enum Metal
    {
        Steel,
        Aluminium,
        Titanium,
        CarbonFiber
    }
    public class Bike
    {
        public Brand BrandOfBike { get; set; }
        public int TireSize { get; set; }
        public Metal MetalOfBike { get; set; }
        public decimal BasePrice = 500m;

        public Bike()
        {

        }
    }
}
