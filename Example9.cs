using System;

namespace Example9
{
    class Program
    {
        static void Del(int x, int y)
        {
            try
            {
                int result = x / y;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Divide By Zero");
                throw e;
            }
        }
        static void Main()
        {
            try
            {
                Del(5, 0);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Program error: {e.Message}");
            }
            Console.ReadLine();
        }
    }
}
