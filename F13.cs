using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F13
    {
        static void Main(string[] args)
        {
            StringWriter str = new StringWriter();
            str.WriteLine("This message is read by StringReader class");
            str.Close();
            // here we are creating StringReader instance and passing StringWriter  
            StringReader sr = new StringReader(str.ToString());

            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());// Reading data
            }
        }
    }
}
