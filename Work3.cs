using System;

namespace Work3
{
    class Program
    {
        static string Reverse(string str)
        {
            if (str.Length == 1)
                return str;
            return str.Substring(str.Length - 1, 1) + Reverse(str.Substring(0, str.Length - 1));
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string: ");
            string s = Console.ReadLine();
            try
            {
                Console.WriteLine(Reverse(s));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
