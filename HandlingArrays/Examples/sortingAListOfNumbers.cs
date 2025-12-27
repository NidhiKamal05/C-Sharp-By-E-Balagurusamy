using System;
class NumberSorting
{
	public static void Main()
	{
		int[] number = {55, 40, 80, 65, 71};
		int n = number.Length;
		Console.Write("Given list : ");
		for(int i = 0; i < n; i++)
		{
			Console.Write(" " + number[i]);
		}
		Console.WriteLine("\n");
		// Sorting begins
		for(int i=0; i<n; i++)
		{
			for(int j=i+1; j<n; j++)
			{
				if(number[i] < number[j])
				{
					// Interchange values
					int temp = number[i];
					number[i] = number[j];
					number[j] = temp;
				}
			}
		}
		Console.Write("Sorted list : ");
		for(int i = 0; i < n; i++)
		{
			Console.Write(" " + number[i]);
		}
		Console.WriteLine("\n");
	}	
}