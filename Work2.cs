using System;

namespace Work2
{
    class Program
    {
        static int Numbers(int n, int d)
        {
            if (n == 0)
            {
                return d;
            }
            return Numbers(n - 1, d) + d;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter d: ");
            int d = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            try
            {
                for (int i = 0; i < n; i++)
                {
                    sum += Numbers(i, d);
                }
                Console.WriteLine($"Sum  = {sum}");
            }
            catch
            {
                Console.WriteLine("Out of range");
            }
        }
    }
}
