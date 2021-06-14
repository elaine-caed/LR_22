using System;

namespace Work41
{
    class Program
    {
        static int IngexMax(int[] array, int len)
        {
            if (len == 0)
            {
                return len;
            }
            int i = IngexMax(array, len - 1);
            return array[len] > array[i] ? len : i;
        }
        static void Main(string[] args)
        {
            int[] array = new int[5];
            try
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine($"Index Of Max: {IngexMax(array, array.Length - 1)}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
