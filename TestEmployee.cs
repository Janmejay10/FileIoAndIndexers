using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoandIndexers
{
    class TestEmployee
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1001, "Robert", "Manager", "sales", "Pune", 500000);

            Console.WriteLine("Eid:" + e1[0]);
            Console.WriteLine("Ename:" + e1[1]);
            Console.WriteLine("Job:" + e1[2]);
            Console.WriteLine("Dname:" + e1[3]);
            Console.WriteLine("Location:" + e1[4]);
            Console.WriteLine("Salary:" + e1[5]);
            Console.Read();
        }
    }
}
