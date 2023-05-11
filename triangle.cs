using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_OOP
{
    internal class triangle:geometric
    {
        public double height;
        public double width;
        public triangle(double i1,double i2)
        {
            this.height = i1;
            this.width = i2;
        }

       public void area()
        {
            Console.WriteLine(0.5*height*width);
        }
       public  void circumference()
        {
            Console.WriteLine(height+height+height);
        }
    }
}
