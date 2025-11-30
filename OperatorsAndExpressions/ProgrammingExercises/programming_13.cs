using System;
class DecrementOperator
{
	static void Main()
	{
		int var = 15;
		int resultVar;
		Console.WriteLine("--Program to demonstrate the use of Decrement Operator in C3--\n");
		Console.WriteLine("--var: First Decrement the value, then assigns it...");
		resultVar = --var;
		Console.WriteLine("after --var:{0},{1}", var, resultVar);
		Console.WriteLine("\nvar--: First, assigns the value and then decrements it...");
		resultVar = var--;
		Console.WriteLine("After var--:{0},{1}", var, resultVar);
	}
}