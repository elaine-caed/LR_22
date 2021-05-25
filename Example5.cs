using System;

namespace Example5
{
    class Program
    {
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write($"{arr[i]}, ");
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] arr = new int[random.Next(10)];
            int[] mas = new int[random.Next(10)];
            try
            {
                arr[random.Next(10)] = random.Next(10);
                mas[0] = random.Next(10);
                int a = arr[0] / mas[0];
                Array.Copy(arr, mas, 5);
                mas[0] = a;
            }
            catch (IndexOutOfRangeException e)
            {
                MyLogger("Out of range", e.Message);
            }
            catch (ArgumentException e)
            {
                MyLogger("Can't copy arr to mas", e.Message);
            }
            catch (Exception e) when (mas[0] == 0)
            {
                MyLogger("Divition By Zero", e.Message);
            }
            catch (Exception e)
            {
                MyLogger("Some other exception", e.Message);
            }
            PrintArray(mas);
        }
    }
}
