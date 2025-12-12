using System;
class IfElseExample
{
	public static void Main()
	{
		string numInput;
		int numValue;
		
		Console.Write("Please enter a number: ");
		numInput = Console.ReadLine();
		numValue = Int32.Parse(numInput);
		
		// A Single Decision with its Action
		if(numValue > 0)
		{
			Console.WriteLine("The number {0} is greater than zero.", numValue);
		}
		// A Single Decision with its Action without brackets
		if(numValue < 0)
			Console.WriteLine("The number {0} is less than zero.", numValue);
		// A Decision with Logical Operator
		if(numValue != 0)
		{
			Console.WriteLine("The number {0} is not equal to zero.", numValue);
		}
		else
		{
			Console.WriteLine("The number {0} is equal to zero.", numValue);
		}
		// Multiple Else If Conditions
		if(numValue < 0 || numValue == 0)
		{
			Console.WriteLine("The number {0} is less than or equal to zero.", numValue);
		}
		else if(numValue > 0 && numValue <= 10)
		{
			Console.WriteLine("The number {0} falls in the range from 1 to 10.", numValue);
		}
		else if(numValue > 10 && numValue <= 20)
		{
			Console.WriteLine("The number {0} falls in the range from 11 to 20.", numValue);
		}
		else if(numValue > 20 && numValue <= 30)
		{
			Console.WriteLine("The number {0} falls in the range from 21 to 30.", numValue);
		}
		else
		{
			Console.WriteLine("The number {0} is greater than 30.", numValue);
		}
	}
}