using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F8
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("f:\\textwriter.txt"))
            {
                Console.WriteLine("here is your content:-");
                Console.WriteLine();
                Console.WriteLine(tr.ReadToEnd());
                Console.Read();
            }
        }
    }
}
