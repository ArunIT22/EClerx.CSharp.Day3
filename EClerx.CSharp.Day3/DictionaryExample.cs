using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EClerx.CSharp.Day3
{
    public class DictionaryExample
    {
        static void Main1(string[] args)
        {
            //Object Initializer
            Product p1 = new Product { Id = 1, Name = "Water Bottle", Price = 500 };
            Product p2 = new Product { Id = 2, Name = "Coffee Mug", Price = 250 };
            Product p3 = new Product { Id = 3, Name = "Web Cam", Price = 4500 };

            //Dictionary Initializer
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                [p1.Name] = p1,
                [p2.Name] = p2,
                [p3.Name] = p3
            };

            //Initialize Dictionary
            Dictionary<string, Product> dProducts = new Dictionary<string, Product>();
            dProducts.Add(p1.Name, p1);
            dProducts.Add(p2.Name, p2);
            dProducts.Add(p3.Name, p3);

            foreach (KeyValuePair<string,Product> item in dProducts)
            {
                Console.WriteLine($"Product Name :{item.Key}");
                Console.WriteLine($"Product Id :{item.Value.Id}\tProduct Name :{item.Value.Name}\tPrice :{item.Value.Price}");
            }

            Console.WriteLine();
            Console.Write("Search : Enter Product Name = ");
            string name = Console.ReadLine();

            foreach (KeyValuePair<string, Product> item in dProducts)
            {
                if (item.Key.Contains(name))
                {
                    Console.WriteLine($"Product Id :{item.Value.Id}\tProduct Name :{item.Value.Name}\tPrice :{item.Value.Price}");
                }                
            }
        }
    }
}
