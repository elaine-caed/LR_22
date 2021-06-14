using System;

namespace Work1
{
    class Program
    {
        static ulong Numbers(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            return Numbers(n - 1) + 1;

        }
        static void Main(string[] args)
        {
            Console.Write(" n = ");
            var n = Convert.ToUInt32(Console.ReadLine());
            try
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"{Numbers(i)} ");
                }
            }
            catch
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}
