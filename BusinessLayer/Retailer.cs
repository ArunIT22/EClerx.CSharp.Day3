namespace BusinessLayer
{
    public class Retailer : ITax
    {
        public int Id { get; set; }
        public string RetailerName { get; set; }
        public string Address { get; set; }

        public Retailer(int id, string retailerName, string address)
        {
            Id = id;
            RetailerName = retailerName;
            Address = address;
        }

        public string GetRetailer()
        {
            return $"Retailer Name :{RetailerName}\nAddress :{Address}";
        }

        public double PayTax()
        {
            return 10;
        }
    }
}
