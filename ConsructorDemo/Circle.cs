using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsructorDemo
{
    public class Circle
    {
        public int r;
        double area;

        public Circle()
        {
            r = 5;
        }

        public Circle(int r)
        {
          this.r = r;
        }

        public void Calculate()
            {
            area = 3.14 * r * r;
             }

        public string Display()
        {
            return $"area of circle is {area}";
        }

    }
}
