using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Circle
    {
        public double radius { get; set; }
        private double area;
        private double circumference;

        public Circle ()
        {
            radius = 0;
        }
       
        private void CalcArea()
        {
            area = Math.PI * radius * radius;
        }
        private void CalcCircumference()
        {
            circumference = 2 * Math.PI * radius;
        }

        public double getArea()
        {
            CalcArea();
            return area;
        }

        public double getCircumference()
        {
            CalcCircumference();
            return circumference;
        }
        
    }
}
