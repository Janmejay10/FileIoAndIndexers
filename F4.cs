using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F4
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("f:\\streamwrite.txt", FileMode.Create);
            StreamWriter s = new StreamWriter(f);

            s.WriteLine("C# StreamWriter class is used to write characters to a stream in specific encoding");
            s.Close();
            f.Close();
            Console.WriteLine("go and check your content in file");
            Console.Read();
        }
    }
}
