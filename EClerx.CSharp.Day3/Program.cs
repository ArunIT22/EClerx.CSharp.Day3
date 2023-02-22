using System;
using BusinessLayer;

namespace EClerx.CSharp.Day3
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //DomesticSeller domestic = new DomesticSeller(1, "ABC inc", "Jaipur", false);
            //Console.Write("Enter the Destination :");
            //string dest = Console.ReadLine();
            //var charges = domestic.CalculateShippingCharges(dest);
            //Console.WriteLine($"Seller Name :{domestic.SellerName}\nSeller Location :{domestic.BaseLocation}" +
            //    $"\nExpress Delivery :{domestic.ExpressDelivery}\nDestincation :{dest}\nShipping Charges :{charges}");

            //InternationalSeller international = new InternationalSeller(1, "XYZ Inc", "Dubai", 2000);
            //Console.Write("Enter the Destination :");
            //string dest1 = Console.ReadLine();
            //var charges1 = international.CalculateShippingCharges(dest1);
            //Console.WriteLine($"Seller Name :{international.SellerName}\nSeller Location :{international.BaseLocation}" +
            //    $"\nExport Charges :{international.ExportCharges}\nShipping Charges :{charges1}");

            // Seller obj = new Seller();

            ITax domesticTax = new DomesticSeller(1, "ABC inc", "Jaipur", false);
            IStateTax domesticStateTax = new DomesticSeller(1, "ABC inc", "Jaipur", false);

            Console.WriteLine($"Central Tax :{domesticTax.PayTax()}");
            Console.WriteLine($"State Tax :{domesticStateTax.PayTax()}");
        }
    }
}
