using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileIoandIndexers
{
    class F11
    {
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.ReadKey();
        }
        static void WriteBinaryFile()
        {
            using (BinaryWriter b = new BinaryWriter(File.Open("f:\\binaryfile1.dat", FileMode.Create)))
            {

                b.Write(125);
                b.Write("here giving a string value");
                b.Write(true);
                b.Write(65.84);
                
            }
        }
        static void ReadBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("f:\\binaryfile1.dat", FileMode.Open)))
            {
                Console.WriteLine("int Value :" + reader.ReadInt32());
                Console.WriteLine("String Value : " + reader.ReadString());
                Console.WriteLine("Boolean Value : " + reader.ReadBoolean());               
                Console.WriteLine("Double Value : " + reader.ReadDouble());
            }
        }
    }
}
