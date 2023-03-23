using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace p04Tax1_Tolentino
{
	public class TaxPayer
	{
		public double income { get; set; }
		public string status { get; set; }
		public int dependents { get; set; }
		private double totalTax;
		private double initalTax;
		private double totalExceptions;
		private double exceptionDependents;
		private double exceptionStatus;

		//Default Constructor
		public TaxPayer()
		{
			income = 0;
			status = "";
			dependents = 0;
		}

		//Constructor With Parameters
		public TaxPayer(double income, string status, int dependents)
		{
			this.income = income;
			this.status = status;
			this.dependents = dependents;
		}

		//Methods
		private void  calcInitialTax()
		{
			if (income < 100001)
				initalTax = income * 0.05;
			else if (income <= 250000)
				initalTax = income * 0.10;
			else if (income <= 500000)
				initalTax = income * 0.15;
			else initalTax = income * 0.20;
		}

		public double getInitialTax()
		{
			calcInitialTax();
			return initalTax;
		}

		private void calcExceptionStatus()
		{
			if (status == "S" || status == "Single") exceptionStatus = 10000;
			else if (status == "M" || status == "Married") exceptionStatus = 20000;
			else if (status == "W" || status == "Widowed") exceptionStatus = 10000;
			else if (status == "D" || status == "Divorced") exceptionStatus = 30000;
			else exceptionStatus = 0;
		}

		private double getExceptionStatus()
		{
			calcExceptionStatus();
			return exceptionStatus;
		}

		private void calcExceptionDependents()
		{
			if (dependents <= 5)
				exceptionDependents = 10000 * dependents;
			else
				exceptionDependents = 50000;
		}

		public double getExceptionDependents()
		{
			calcExceptionDependents();
			return exceptionDependents;
		}

		private void calcTotalExceptions()
		{
			totalExceptions = getExceptionStatus() + getExceptionDependents();
		}

		public double getTotalExceptions()
		{
			calcTotalExceptions();
				return totalExceptions;
		}

		private void calcTotalTax()
		{
			totalTax = getInitialTax() - getTotalExceptions();
		}

		public double getTotalTax()
		{
			calcTotalTax();
			return totalTax;
		}
	}
}
