using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIoandIndexers
{
    class F12
    {
        static void Main(string[] args)
        {
            string text = "stringwriter class is to write and deal with strig data\n" +
                "It is derived class of TextWriter class \n" +
                "data written by StringWriter class is stored into StringBuilder.";
             
            StringBuilder sb = new StringBuilder();// Creating StringBuilder instance               
            StringWriter sw = new StringWriter(sb);// Passing StringBuilder instance into StringWriter           
            sw.WriteLine(text);// Writing data using StringWriter  
            sw.Flush();            
            sw.Close();// Closing writer connection            
            StringReader sr = new StringReader(sb.ToString());// Creating StringReader instance and passing StringBuilder               
            while (sr.Peek() > -1)
            {
                Console.WriteLine(sr.ReadLine());// Reading data 
            }
            Console.Read();
        }
    }
}
