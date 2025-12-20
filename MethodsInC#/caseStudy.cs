//
// ********************************************************
// This program demonstrates method overloading in a real world scenario for tax calculation.
// ***********************************************************
using System;
class TaxCalc
{
	// This method takes four arguments: Two amounts values and Two
	// rates values and returns the taxable amount
	public double TaxCalculator(double taxAmount1, double taxRate1, double taxAmount2, double taxRate2)
	{
		double taxAmount;
		Console.WriteLine("--Using TaxCalculator method containing 4 arguments.--");
		taxAmount = (taxAmount1 * taxRate1) + (taxAmount2 * taxRate2);
		return taxAmount;
	}
	
	// This method takes four arguments: One amount value and One rate
	// value and returns the taxable amount
	public double TaxCalculator(double taxAmount1, double taxRate1)
	{
		double taxAmount;
		Console.WriteLine("--Using TaxCalculator method containing 2 arguments.--");
		taxAmount = taxAmount1 * taxRate1;
		return taxAmount;
	}
	
	// This method takes one argument: One amount value and returns the
	// taxable amount
	public double TaxCalculator(double taxAmount1)
	{
		double taxRate = 0.12;
		double taxAmount = 0;
		Console.WriteLine("--Using TaxCalculator method containing 1 argument only.--");
		taxAmount = taxAmount1 * taxRate;
		return taxAmount;
	}
	
	// This method also takes one argument: Tax Type (string) and returns
	// the tax rate
	public double TaxCalculator(string taxType)
	{
		double taxRate = 0;
		Console.WriteLine("--Using TaxCalculator method containing 1 argument only of String type.--");
		if(taxType == "Personal")
			taxRate = 0.10;
		return taxRate;
	}
}

class MethodOverload
{
	static void Main(string[] args)
	{
		string userResponse;
		bool flagHome = false;
		bool flagBussiness = false;
		
		double houseRate = 0;
		double houseValue = 0;
		double businessSales = 0;
		double taxRate = 0;
		double earning = 0;
		double totalTax = 0;
		
		TaxCalc tc = new TaxCalc();
		
		Console.WriteLine("Do you have a house registered in your name? (y/n)");
		userResponse = Console.ReadLine();
		if(userResponse == "y")
		{
			flagHome = true;
			Console.WriteLine("Enter the worth of the house in Rupees: ");
			userResponse = Console.ReadLine();
			houseValue = Convert.ToDouble(userResponse);
			Console.WriteLine("Enter the tax rate applicable for a house: ");
			userResponse = Console.ReadLine();
			houseRate = Convert.ToDouble(userResponse);
		}
		
		Console.WriteLine("Are you an owner of a business? (y/n)");
		userResponse = Console.ReadLine();
		if(userResponse == "y")
		{
			flagBussiness = true;
			Console.WriteLine("Enter the total sales for the year: ");
			userResponse = Console.ReadLine();
			businessSales = Convert.ToDouble(userResponse);
			Console.WriteLine("Enter the gross sales tax rate: ");
			userResponse = Console.ReadLine();
			taxRate = Convert.ToDouble(userResponse);
		}
		
		if(flagHome && !flagBussiness)
			totalTax = tc.TaxCalculator(houseValue, houseRate);
		else if(!flagHome && flagBussiness)
			totalTax = tc.TaxCalculator(businessSales, taxRate);
		else if(flagHome && flagBussiness)
			totalTax = tc.TaxCalculator(houseValue, houseRate, businessSales, taxRate);
		
		Console.WriteLine("Enter your total earnings for the year in Rupees: ");
		userResponse = Console.ReadLine();
		earning = Convert.ToDouble(userResponse);
		totalTax = totalTax + tc.TaxCalculator(earning);
		
		Console.WriteLine("Your total tax calculated is {0}", totalTax);
		Console.WriteLine("The Personal tax rate is {0}", tc.TaxCalculator("Personal"));
	}
}