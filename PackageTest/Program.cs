using System;
using System.Collections.Generic;

namespace PackageTest
{
    class Program
    {
        static void Main(string[] args)
        {
           var product1 = new OvernightPackage("Mike Olorunsogo", "Divine estate, ajah", "08023344765", "Peter Bello", "Agric, Ikorodu","0806532289", "Clothes", 44, 2000M, 500M);
            var product2 = new TwoDayPackage("Olowu Juwon", "17, papa-ajao Mushin", "08140241451", "Oyinlola asaju", "Tanke, ilorin", "09093185833", "Sneakers foot wear", 4, 7000M, 120M);
            var product3 = new TwoDayPackage("Favour samuel", "Abia , Unuahaia", "07055142832", "James Cryuff", "oyo atiba, oyo", "09043586502", "Fashion Bag", 20, 4500M, 320M);

            Console.WriteLine($"Package one details:\n\n{product1}\n");
            Console.WriteLine($"Package two details:\n\n{product2}\n");
            Console.WriteLine($"Package three details:\n\n{product3}\n");

            List<Packages> products = new List<Packages>(){product1, product2, product3};

            decimal totalShippingCost = 0;
            foreach (var goods in products)
            {
                totalShippingCost += goods.ShippingCost;
            }

            Console.Write($"Total Shipping cost for all packages is: {totalShippingCost:C}");
        }
    }
}
