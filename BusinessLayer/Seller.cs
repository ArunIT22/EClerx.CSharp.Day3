using System;
using System.Configuration;
using System.Linq;

namespace BusinessLayer
{
    public enum Domestic
    {
        Chennai,
        Hyderabad,
        Bengaluru
    }

    public abstract class Seller
    {

        public int Id { get; set; }
        public string SellerName { get; set; }
        public string BaseLocation { get; set; }

        public Seller(int id, string sellerName, string baseLocation)
        {
            Id = id;
            SellerName = sellerName;
            BaseLocation = baseLocation;
        }

        public abstract double CalculateShippingCharges(string destination);

    }

    public class DomesticSeller : Seller, ITax, IStateTax
    {
        public bool ExpressDelivery { get; set; }

        public DomesticSeller(int id, string name, string location, bool delivery) : base(id, name, location)
        {
            ExpressDelivery = delivery;
        }

        public override double CalculateShippingCharges(string destination)
        {
            var locations = Enum.GetNames(typeof(Domestic));
            double shippingCharges = 0;
            if (locations.Contains(destination))
            {
                if (destination == "Chennai" || destination == "Bengaluru" || destination == "Hyderabad")
                {
                    shippingCharges = 50;
                }
                if (ExpressDelivery)
                {
                    shippingCharges += 100;
                }
            }
            else
            {
                shippingCharges = 100;
            }
            return shippingCharges;
        }

        double ITax.PayTax()
        {
            return 15;
        }

        double IStateTax.PayTax()
        {
            return 10;
        }

        //public double PayTax()
        //{
        //    return 15;
        //}
    }

    public class InternationalSeller : Seller, ITax
    {
        public double ExportCharges { get; set; }

        public InternationalSeller(int id, string name, string location, double charges) : base(id, name, location)
        {
            ExportCharges = charges;
        }

        public override double CalculateShippingCharges(string destination)
        {
            double shippingCharges;
            if (destination == "NewYork" || destination == "Chicago")
            {
                shippingCharges = 1000;
                shippingCharges += ExportCharges;
            }
            else
            {
                shippingCharges = 2000;
                shippingCharges += ExportCharges;
            }
            return shippingCharges;
        }

        public double PayTax()
        {
            return 18;
        }
    }
}
