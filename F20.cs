using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FileIoandIndexers
{
    class Student1
    {
        public int rollno;
        public string name;
        public Student1(int rollno, string name)
        {
            this.rollno = rollno;
            this.name = name;
        }
    }

    public class DeserializeExample
    {
        public static void Main(string[] args)
        {
            FileStream stream = new FileStream("e:\\sss.txt", FileMode.OpenOrCreate);
            BinaryFormatter formatter = new BinaryFormatter();

            Student1 s1 = (Student1)formatter.Deserialize(stream);
            Console.WriteLine("Rollno: " + s1.rollno);
            Console.WriteLine("Name: " + s1.name);

            stream.Close();
            Console.Read();
        }
    }
}