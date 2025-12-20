using System;
class Avg
{
	public int avgVal(params int[] intData)
	{
		int sum=0, avg=0;
		if(intData.Length == 0)
		{
			Console.WriteLine("Error: no arguments.");
			return 0;
		}
		for(int i=0; i<intData.Length; i++)
		{
			sum=sum+intData[i];
		}
		avg=sum/intData.Length;
		return avg;
	}
}
public class ParamsSample
{
	public static void Main()
	{
		Avg objAvg = new Avg();
		int average;
		int num1 = 50, num2 = 100;
		// Calling the Average function using two parameters
		average = objAvg.avgVal(num1, num2);
		Console.WriteLine("Average of two parameter values is: " + average);
		// Calling the Average function using three parameters
		average = objAvg.avgVal(num1, num2, 150);
		Console.WriteLine("Average of three parameter values is: " + average);
		// Calling the Average function using five parameters
		average = objAvg.avgVal(30, 40, 50, 60, 70);
		Console.WriteLine("Average of five parameter values is: " + average);
		// Calling the Average function using an integer array
		int[] args = {25, 35, 45, 55, 65, 75};
		average = objAvg.avgVal(args);
		Console.WriteLine("Average of parameter values contained in an array is: " + average);
	}
}