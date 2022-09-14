using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsructorDemo
{
    public class Employee
    {
        int empid;
        string empname;
        int basicsalary, allowance;

        public Employee()
        {
            empid = 12;
            empname = "shriraj";
            basicsalary = 20000;
            allowance = 3000;
        }
        public Employee(int empid, string empname, int basicsalary, int allowance)
        {
            this.empid = empid;
            this.empname = empname;
            this.basicsalary = basicsalary;
            this.allowance = allowance;
        }

        public void Calculate()
        {

        }

        public string Display()
        {
            return $" Employee details:\nempid {empid} \nempname {empname} \n basicsalary {basicsalary} \n allowance {allowance} ;
        }

    }
}
