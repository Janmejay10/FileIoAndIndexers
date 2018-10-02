using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIoandIndexers
{
    class Employee
    {
        int Eid;
        string Ename, Job, Dname, Location;
        double Salary;
        // now to initialize these attributes we define a paramerized constructor
        public Employee(int Eid, string Ename, string Job, string Dname, string Location, double Salary)
        {
            this.Eid = Eid;
            this.Ename = Ename;
            this.Job = Job;
            this.Dname = Dname;
            this.Location = Location;
            this.Salary = Salary;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)          //there is one more benifit of indexer
                    return Eid;           // that it is not mandatory to start the index from 0 to n-1
                else if (index == 1)      // we could have started the index from 1 to n also
                    return Ename;       // it totally depends on us becuse it is not a pre-defined array
                else if (index == 2)     // it is a virtual array and behaves like array
                    return Job;
                else if (index == 3)
                    return Dname;
                else if (index == 4)
                    return Location;
                else if (index == 5)
                    return Salary;
                return null;

            }
            set
            {
                if (index == 0) // means we are going to assign a value to employeeId(Eid)
                    Eid = (int)value;
                // same rules for others also

            }
        }

    }
}
