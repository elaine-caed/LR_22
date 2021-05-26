using System;

namespace Example11
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
				int a = int.Parse(args[0]);
				int b = int.Parse(args[1]);
				Console.WriteLine($"result: {a}+{b} = {a + b}");
			}
			catch (FormatException)
			{
				Console.WriteLine("Enter just a number next time!");
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("You need 2 arguments");
			}
			catch (OverflowException)
			{
				Console.WriteLine("number range in {0:E} - {1:E}", int.MinValue, int.MaxValue);
			}
		}
    }
}
