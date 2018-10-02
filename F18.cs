using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F18  //for deleting directory
    {
        static void Main(string[] args)
        {
              
            DirectoryInfo directory = new DirectoryInfo(@"F:\javatpoint");// Providing directory name with complete location.
            try
            {
                  
                directory.Delete();// Deleting directory
                Console.WriteLine("The directory is deleted successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong: {0}", e.ToString());
            }
            Console.Read();
        }
    }
}
