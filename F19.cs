﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Student
{
    int rollno;
    string name;
    public Student(int rollno, string name)
    {
        this.rollno = rollno;
        this.name = name;
    }
}
public class SerializeExample
{
    static void Main(string[] args)
    {
        FileStream stream = new FileStream("e:\\sss.txt", FileMode.OpenOrCreate);
        BinaryFormatter formatter = new BinaryFormatter();

        Student s = new Student(101, "sonoo");
        formatter.Serialize(stream, s);

        stream.Close();
        Console.Read();
    }
}