using System;

namespace Example13
{
    class Program
    {
        static void Main(string[] args)
        {
			int a = int.MinValue;
			int b = int.MinValue;
			try
			{
				a = int.Parse(args[0]);
				b = int.Parse(args[1]);
				Console.WriteLine($"result: {a}+{b} = {a + b}");
				checked
				{
					Console.WriteLine($"result: {a}+{b} = {a + b}");
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("Enter just a number next time!");
			}
			catch (IndexOutOfRangeException)
			{
				Console.WriteLine("You need 2 arguments");
			}
			catch (OverflowException) when (a != int.MinValue && b != Int32.MinValue)
			{
				Console.WriteLine($"result: {a}+{b} = {double.NaN}");
			}
			catch (OverflowException)
			{
				Console.WriteLine("number range in {0:E} - {1:E}", int.MinValue, int.MaxValue);
			}
		}
    }
}
