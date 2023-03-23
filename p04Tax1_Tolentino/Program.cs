using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p04Tax1_Tolentino
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TaxPayer payer = new TaxPayer();
			Console.Write("Enter Income: ");
			payer.income = double.Parse(Console.ReadLine());
			Console.Write("Enter Status: ");
			payer.status = Console.ReadLine();
			Console.Write("Enter Dependents: ");
			payer.dependents = int.Parse(Console.ReadLine());

			Console.WriteLine("Total Tax: " + payer.getTotalTax());
		}
	}
}
