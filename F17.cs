using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F17  //for creating directory
    {
        static void Main(string[] args)
        {
             
            DirectoryInfo directory = new DirectoryInfo(@"F:\C#.net");// Provide directory name with complete location. 
            try
            {
                  
                if (directory.Exists) // Check, directory exist or not.
                {
                    Console.WriteLine("Directory already exist.");
                    return;
                }
                  
                directory.Create(); // Creating a new directory.
                Console.WriteLine("The directory is created successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Directory not created: {0}", e.ToString());
            }
            Console.Read();
        }
    }
}
