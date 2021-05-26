using System;

namespace Example15
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				Del(5, 0);
			}
			catch (Exception e)
			{
				Console.WriteLine($"Program error: {e.Message}");
			}
		}
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
    }
}
