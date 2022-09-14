using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsructorDemo
{
    public class Student
    {
        int rollno,mark1,mark2,mark3;
        string name;
        int total;
        float percent;

        public Student()
        {
            rollno = 2;
            name = "ankita";
            mark1 = 58;
            mark2 = 60;
            mark3 = 62;
        }

        public Student(int rollno, string name, int mark1,int mark2,int mark3)
        {
            this.rollno = rollno;
            this.name = name;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
        }

        public void percentage()
        {
            total = mark1 + mark2 + mark3;
            percent = total / 3;
        }
        public string Display()
        {
            return $"student details:\n rollno {rollno} \n name {name} \n total: {total} \n percentage: {percent}";
        }
    }
}
