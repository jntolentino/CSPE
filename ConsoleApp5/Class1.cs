using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp5
{
    internal class Rectangle
    {
        //properties
        public double length { get; set; }
        public double width { get; set; }
        private double area;
        private double perimeter;

        //methods
        //default constructors
        public Rectangle ()
        {
            length = 0;
            width = 0;
        }
        //constructor with parameters
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        //copy constructor
        public Rectangle(Rectangle r)
        {
            this.length = r.length;
            this.width = r.width;
        }

        private void CalcArea()
        {
            area = length * width;
        }

        private void CalcPerimeter()
        {
            perimeter = (length * 2) + (width * 2);
        }

        public double getArea()
        {
            CalcArea();
            return area;
        }

        public double getPerimeter()
        {
            CalcPerimeter();
            return perimeter; 
        }
    }
}
