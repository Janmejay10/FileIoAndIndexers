using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F10
    {
        static void Main(string[] args)
        {
            string fileName = "f:\\binaryfile.dat";
            using (BinaryWriter bw = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                bw.Write(5);
                bw.Write(true);
                bw.Write("here giving a string value");
            }
            Console.WriteLine("you can read the content now");
            Console.Read();
        }
    }
}
