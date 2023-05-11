using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            triangle oop1;
            oop1 = new triangle(6, 8);
            oop1.area();
            oop1.circumference();
            square oop2;
            oop2 = new square(8);
            oop2.area();
            oop2.circumference();

            
        }
    }
}
