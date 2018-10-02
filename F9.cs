using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F9
    {
        static void Main(string[] args)
        {
            using (TextReader tr = File.OpenText("f:\\textwriter.txt"))
            {
                Console.WriteLine("\n The first line of text is:- ");
                Console.WriteLine(tr.ReadLine());
                Console.Read();
            }
        }
    }
}
