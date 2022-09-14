using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsructorDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            Employee e1 = new Employee(23,"vikas",100000,20000);

            Student s1 = new Student();
            Student s2 = new Student(4,"onkar",56,78,65);

            Circle c = new Circle();
             Circle c2 = new Circle(1);

            Rectanangle r = new Rectanangle();
            Rectanangle r1 = new Rectanangle(3,6);

              s1.percentage();
              s2.percentage();
              Console.WriteLine( s1.Display());
              Console.WriteLine(s2.Display());

            e.Calculate();
            e1.Calculate();
            Console.WriteLine(e.Display());
            Console.WriteLine(e1.Display());

            c.Calculate();
            c2.Calculate();
            Console.WriteLine(c.Display());
            Console.WriteLine(c2.Display());

            r.Calculate();
            r1.Calculate();
            Console.WriteLine(r.Display());
            Console.WriteLine(r1.Display());
        }
    }
}
