using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F1
    {
        static void Main(string[] args)
        {
            FileStream f = new FileStream("f:\\filestream1.txt", FileMode.OpenOrCreate);  
            f.WriteByte(65); 
            f.Close();
            Console.Read();
        }
    }
}
