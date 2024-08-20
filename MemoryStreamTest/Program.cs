using System;
using System.IO;
using System.Text;

namespace MemoryStreamTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var memoryStream = new MemoryStream())
            {
                using(var streamWriter =  new StreamWriter(memoryStream))
                {
                    streamWriter.WriteLine("The value is {0:0.00}", 123.45678);
                }
                Console.WriteLine(Encoding.UTF8.GetString(memoryStream.ToArray()));
            }
        }
    }
}
