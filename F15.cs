using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F15
    {
        static void Main(string[] args)
        {
            {
                try
                {

                    string s1 = "F:\\fileinfo.txt";  // Specifying file location 

                    FileInfo file = new FileInfo(s1); // Creating instance of FileInfo 

                    StreamWriter sw = file.CreateText(); // here creating instance to write

                    sw.WriteLine("text written to file by using streamwriter class");

                    sw.Close();
                }
                catch (IOException e)
                {
                    Console.WriteLine("Something went wrong: " + e);
                }
            }
            Console.Read();
        }
    }
}
