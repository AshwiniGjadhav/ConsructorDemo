using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsructorDemo
{
    public class Rectanangle
    {
        int x, y,area;

        public Rectanangle()
        {
            x = 4;
            y = 5;
        }

        public Rectanangle(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Calculate()
        {
            area = 2 * (x + y);  
        }

        public string Display()
        {
            return $"AREA OF RECTANANGLE IS {area}";
        }
    }
}
