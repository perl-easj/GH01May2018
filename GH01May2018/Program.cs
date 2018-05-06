using System;

namespace GH01May2018
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("AB 34 510", 80000);
            Console.WriteLine(c);
            Console.WriteLine("Press any key to close...");
            Console.ReadKey();
        }
    }
}
