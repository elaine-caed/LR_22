using System;

namespace Example7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masA = new int[3];
            double c;
            try
            {
                int i = Convert.ToInt32(Console.ReadLine());
                int a = Convert.ToInt32(Console.ReadLine());
                masA[i] = a;
                c = 1 / masA[i];
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Divide By Zero Exception");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Index Out Of Range Exception");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
