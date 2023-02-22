using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EClerx.CSharp.Day3
{
    public class ExceptionExample
    {
        static void Main1(string[] args)
        {
            //int x = int.MaxValue;
            //int y = int.MaxValue;     
            //int[] arr=new int[2];
            //try
            //{
            //    //int z = checked(x * y);
            //    int z = x * y;
            //    Console.WriteLine($"Z :{z}");
            //    //arr[3] = 500;

            //    //Connect to DB
            //    //Create a New Record                
            //}                      
            //catch (OverflowException ex)
            //{
            //    Console.WriteLine("Error Occurred");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //finally
            //{
            //    //Close DB Connection
            //    Console.WriteLine("Finally Block");
            //}
            //Console.WriteLine("Hello World!!!");

            try
            {
                Console.Write("Enter the Quantity :");
                int Quantity = int.Parse(Console.ReadLine());
                if (Quantity < 0)
                {
                    throw new ProductException("Quantity cannot be less than zero");
                }
            }
            catch (ProductException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.Read();
        }
    }
}
