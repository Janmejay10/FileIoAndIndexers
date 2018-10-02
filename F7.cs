using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F7
    {
        static void Main(string[] args)
        {
            using (TextWriter wr = File.CreateText("f:\\textwriter.txt"))
            {
                wr.WriteLine("C# TextWriter class is an abstract class.");
                wr.WriteLine("It is used to write text or sequential series of characters into file");
                wr.WriteLine("It is found in System.IO namespace.");
            }
            Console.WriteLine("go and check your content");
            Console.Read();
        }
    }
}
