using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_OOP
{
    internal class square:geometric
    {
        int height;
        public square(int d)
        {
            this.height = d;
        }
        public void area()
        {
            Console.WriteLine(height*height);
        }
        public void circumference()
        {
            Console.WriteLine(height*4);
        }
    }
}
