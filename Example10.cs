using System;

namespace Example10
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a = int.Parse(args[0]);
                int b = int.Parse(args[1]);
                Console.WriteLine($"result: {a}+{b} = {a + b}");
            }
            catch
            {
                Console.WriteLine("Somethings wrong :(");
            }
        }
    }
}
