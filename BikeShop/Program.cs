using BikeShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BikeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Bike bike = new Bike();
            decimal PriceSize = 0m;
            decimal PriceMetal = 0m;
            decimal GST = 0m;
            decimal SubTotal = 0m;
            decimal Total = 0m;
            decimal amountDonation = 0m;

            string start = "The Right Speed Bike Shop \n";
            string snow = "*";
            Console.WriteLine(start);
            for(int i=0; i<start.Length; i++)
            {
                Console.Write(snow);
            }
            Console.Write("\n");


            Console.Write("Enter your name >>");
            customer.Name = Console.ReadLine();
            
            
            bool x = true;
            do
            {
                Console.Write(@"Brand
    a) Trek
    b) Giant
    c) Specialized
    d) Raleigh
Make a selection [a, b, c, d] >>");
                string brand = Console.ReadLine();
                switch (brand)
                {
                    case "a":
                        bike.BrandOfBike = Brand.Trek;
                        x = false;
                        break;
                    case "b":
                        bike.BrandOfBike = Brand.Giant;
                        x = false;
                        break;
                    case "c":
                        bike.BrandOfBike = Brand.Specialized;
                        x = false;
                        break;
                    case "d":
                        bike.BrandOfBike = Brand.Raleigh;
                        x = false;
                        break;
                    default:
                        Console.WriteLine("You don't choose Brand");
                        break;
                }
            }
            while (x);


            bool y = true;
            do
            {
                Console.Write("Choose a tire size [20-26] 17.50$ per inch >> ");
                int size = int.Parse(Console.ReadLine());
                if(20<= size && size <= 26)
                {
                    PriceSize = 17.5m * (decimal)size;
                    y = false;
                }
                else
                {
                    Console.WriteLine("Enter size from 20 to 26");
                }
            }
            while (y);


            bool z = true;
            while (z)
            {
                Console.Write(@"Enter the number of your corresponding choice of metal.
    1) Steel [$0]
    2) Aluminium [$175]
    3) Titanium [$425]
    4) Carbon Fiber [$615]
Choice [1-4] >>");
                int metal = int.Parse(Console.ReadLine());
                switch (metal)
                {
                    case 1:
                        bike.MetalOfBike = Metal.Steel;
                        PriceMetal = 0m;
                        z = false;
                        break;
                    case 2:
                        bike.MetalOfBike = Metal.Aluminium;
                        PriceMetal = 175m;
                        z = false;
                        break;
                    case 3:
                        bike.MetalOfBike = Metal.Titanium;
                        PriceMetal = 425m;
                        z = false;
                        break;
                    case 4:
                        bike.MetalOfBike = Metal.CarbonFiber;
                        PriceMetal = 615m;
                        z = false;
                        break;
                    default:
                        Console.WriteLine("You don't choose Metal");
                        break;
                }
            }
            


            Console.Write("Would you like to make a donation to the Green Earth Fund [y/n] >> ");
            string donation = Console.ReadLine();
            switch (donation)
            {
                case "y":
                    Console.Write("Amount >>");
                    amountDonation = decimal.Parse(Console.ReadLine());
                    break;
                case "n":
                    break;
                default:
                    break;
            }

            SubTotal = bike.BasePrice + PriceSize + PriceMetal;
            GST = SubTotal / 100 / 5;
            Total = SubTotal + GST + amountDonation;

            Console.WriteLine($@"
Invoice and Packing Slip

Customer:                    {customer.Name}
Brand:                       {bike.BrandOfBike}
Base Price:                      {bike.BasePrice}
Tire Size Premium:               {PriceSize}
Metal Selection Premium          {PriceMetal}
                               - - - - - - - -
Sub Total                        {SubTotal}
GST                              {GST}
                               ---------------
                               ---------------
Donation to Green Earth          {amountDonation}
Total:                           {Total}");



            Console.ReadLine();
        }
    }
}
