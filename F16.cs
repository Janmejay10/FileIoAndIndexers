using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F16
    {
        static void Main(string[] args)
        {
            {
                try
                {

                    string s1 = "F:\\fileinfo.txt";  // Specifying file location 

                    FileInfo file = new FileInfo(s1); // Creating instance of FileInfo 

                    StreamReader sr = file.OpenText(); // here creating instance to read

                    string data = "";

                    while((data = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(data);
                    }

                    sr.Close();
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
