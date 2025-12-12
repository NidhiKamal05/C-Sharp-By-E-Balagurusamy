using System;
class InterestCalculator
{
	public static void Main()
	{
		Console.WriteLine("--Interest Calculator--");
		Console.WriteLine("Calculate Simple (S) / Compound (C) Interest: ");
		string choice=Console.ReadLine();
		
		Console.WriteLine("Enter Principal Amount: ");
		double p=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Rate of Interest: ");
		double r=double.Parse(Console.ReadLine());
		Console.WriteLine("Enter Duration: ");
		int t=Int32.Parse(Console.ReadLine());
		
		if(choice=="S")
		{
			double simpleInterest=(double)((p*r*t)/100);
			Console.WriteLine("The Simple Interest is: {0,0:Rs###.##",simpleInterest);
		}
		else
		{
			double compoundInterest=(double)p^(Math.Pow(((r/100)+1),t));
			Console.WriteLine("The Compound Interest is: {0,0:Rs###.##",compoundInterest);
		}
	}
}