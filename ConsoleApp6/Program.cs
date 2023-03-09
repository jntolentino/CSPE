using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle C1 = new Circle();
            Console.WriteLine("C1 Area: " + C1.getArea());
            Console.WriteLine("C1 Circumference: " + C1.getCircumference());
        }
    }
}
