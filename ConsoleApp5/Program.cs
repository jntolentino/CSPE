using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle();
            Console.WriteLine("r1 Area: " + r1.getArea());
            Console.WriteLine("r1 Perimeter: " + r1.getPerimeter());

            Rectangle r2 = new Rectangle();
            Console.WriteLine("Enter Length: ");
            r2.length = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Width:");
            r2.width = double.Parse(Console.ReadLine());

            Console.WriteLine("r2 Area: " + r2.getArea());
            Console.WriteLine("r2 Perimeter: " + r2.getPerimeter());

            Rectangle r3 = new Rectangle(4,6);
            Console.WriteLine("r3 Area: " + r3.getArea());
            Console.WriteLine("r3 Perimeter: " + r3.getPerimeter());

            Rectangle r4 = new Rectangle(r3);
            Console.WriteLine("r4 Area: " + r4.getArea());
            Console.WriteLine("r4 Perimeter: " + r4.getPerimeter());


        }
    }
}
