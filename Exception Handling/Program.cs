using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
// prompts the user to enter two numbers
            double no1 = 0,  no2 = 0, quotient = 0;

            try
            {
                Console.WriteLine("Enter the First Number: ");
                no1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the First Number: ");
                no2 = double.Parse(Console.ReadLine());
//Calculating the Quotient
                quotient = no1 / no2;
            }

            catch (FormatException e )
            {
                Console.WriteLine("Entry is not a Number");
            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Cannot Divide by Zero");
            }
            finally
            {
                Console.WriteLine("The Quotient is: " + quotient);
            }
        }
    }
}
