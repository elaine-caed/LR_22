using System;

namespace Example2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[random.Next(10)];
            int[] mas = new int[random.Next(10)];
            try
            {
                arr[random.Next(10)] = random.Next(10);
                Array.Copy(arr, mas, 5);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Can't copy arr to mas");
            }
        }
    }
}
