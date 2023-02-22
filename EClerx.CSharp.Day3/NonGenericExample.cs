//using System;
//using System.Collections;

//namespace EClerx.CSharp.Day3
//{
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public double Price { get; set; }
//    }

//    public class ProductDetails
//    {
//        public ArrayList Products { get; set; }

//        public ProductDetails()
//        {
//            Products = new ArrayList();
//        }

//        public void AddProduct(Product product)
//        {
//            Products.Add(product);
//            Products.Add(100);
//        }

//        public ArrayList GetProducts()
//        {
//            return Products;
//        }

//        public void RemoveProduct(Product product)
//        {
//            Products.Remove(product);
//        }

//        static void Main(string[] args)
//        {
//            ProductDetails details = new ProductDetails();

//            //Object Initializer
//            Product p1 = new Product { Id = 1, Name = "Water Bottle", Price = 500 };
//            Product p2 = new Product { Id = 2, Name = "Coffee Mug", Price = 250 };
//            Product p3 = new Product { Id = 3, Name = "Web Cam", Price = 4500 };

//            //Add new product to arraylist
//            details.AddProduct(p1);
//            details.AddProduct(p2);
//            details.AddProduct(p3);

//            details.RemoveProduct(p2);

//            //Get the List of Products
//            var products = details.GetProducts();

//            Console.WriteLine($"{"Product Id",-10}\t{"Product Name",-15}\t{"Price"}");
//            foreach (object prd in products)
//            {
//                if (prd is Product p)
//                {
//                   // Product p = (Product)prd;
//                    Console.WriteLine($"{p.Id,-10}\t{p.Name,-15}\t{p.Price}");
//                }
//            }
//        }

//    }
//}
