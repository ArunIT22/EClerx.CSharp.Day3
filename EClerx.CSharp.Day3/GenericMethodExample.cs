using System;

namespace EClerx.CSharp.Day3
{
    public class GenericMethodExample
    {
        public void Swap<T>(T a,T b)
        {
            Console.WriteLine($"Before Swap :{a}\t{b}");
            T temp = a;
            a = b;
            b = temp;
            Console.WriteLine($"After Swap :{a}\t{b}");
        }

        //public void Swap(string a, string b)
        //{
        //    Console.WriteLine($"Before Swap :{a}\t{b}");
        //    string temp = a;
        //    a = b;
        //    b = temp;
        //    Console.WriteLine($"After Swap :{a}\t{b}");
        //}
    }

    public class ExecuteClass
    {
        static void Main1(string[] args)
        {
            GenericMethodExample obj = new GenericMethodExample();
            obj.Swap<int>(10, 20);
            obj.Swap<string>("ABC", "XYZ");
        }
    }
}
