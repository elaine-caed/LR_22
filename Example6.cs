using System;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream stream = null;
            try
            {
                stream = new FileStream("d://1.txt", FileMode.Open);
                int b;
                while ((b = stream.ReadByte()) != -1)
                {
                    Console.Write((char)b);
                }
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
        }
    }
}
