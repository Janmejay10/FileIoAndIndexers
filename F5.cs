using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F5
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("f:\\streamread.txt", FileMode.OpenOrCreate);
            StreamReader s = new StreamReader(f);

            string line = s.ReadLine();
            Console.WriteLine(line);

            s.Close();
            f.Close();
            Console.Read();
        }
    }
}
