using System;
class forExample
{
	public static void Main()
	{
		int num1=0, num2=10;
		for(;((num1<=10)&&(num2>=0)); num2--, num1++)
		{
			System.Console.WriteLine("First Number {0} is {1} than Second Number {2}.\t", num1, (num1>num2?'>':'<'), num2);
		}
	}
}