using System;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double x = 1 / new Random().Next(0, 6);
                Console.WriteLine($"{x}");
            }
            catch
            {
                Console.WriteLine("Divide By Zero");
            }
        }
    }
}
