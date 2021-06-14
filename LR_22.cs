using System;

namespace LR_22
{
    class Program
    {
        static void Fill(int[] arr)
        {
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 25);
            }
        }
        static void Write(int[] arr)
        {
            Console.Write("Your array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();
        }
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }
        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {

                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }
            return array;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter size: ");
            try
            {
                int size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                Fill(array);
                Write(array);
                Console.WriteLine("Sorted array: {0} ", string.Join(", ", InsertionSort(array)));
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Incorrect size of array");
            }
        }
    }
}
