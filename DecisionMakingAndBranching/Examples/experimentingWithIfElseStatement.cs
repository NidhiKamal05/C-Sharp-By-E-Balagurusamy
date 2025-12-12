using System;
class IfElseTest
{
	public static void Main()
	{
		int[] number = {50, 65, 56, 71, 81};
		int even = 0, odd = 0;
		
		for(int i = 0; i < number.Length; i++)
		{
			if((number[i] % 2) == 0)
			{
				even += 1; // counting EVEN numbers
			}
			else
			{
				odd += 1; // counting ODD numbers
			}
		}
		
		Console.WriteLine("Even Numbers : " + even);
		Console.WriteLine("Odd Numbers : " + odd);
	}
}