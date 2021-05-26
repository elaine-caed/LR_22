using System;

namespace Example14
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Enter number for x value:");
			int x = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter number for y value:");
			int y = int.Parse(Console.ReadLine());
			try
			{
				Console.WriteLine(MyDiv(x, y));
			}

			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
		private static double MyDiv(int a, int b)
		{

			if (b == 0)
				throw new Exception("Division by zero");
			return (double)a / b;
		}
    }
}
