using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F14
    {
        static void Main(string[] args)
        {
            {
                try
                {
                    
                    string s1 = "F:\\fileinfo.txt";  // Specifying file location 
                      
                    FileInfo file = new FileInfo(s1); // Creating instance of FileInfo 
                      
                    file.Create(); // empty file is being created 
                    Console.WriteLine("File created");
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
