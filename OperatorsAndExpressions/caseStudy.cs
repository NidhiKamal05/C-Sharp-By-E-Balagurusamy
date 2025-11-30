using System;
class Convert
{
	public int nobits;
	public Convert(int n)
	{
		nobits = n;
	}
	public void ConvertToBinary(int num)
	{
		int mask = 1;
		mask <<= nobits-1;
		int spaceVal = 0;
		for(; mask != 0; mask >>= 1)
		{
			if((num & mask) != 0)
				Console.Write("1");
			else
				Console.Write("0");
			spaceVal++;
			if((spaceVal % 8) == 0)
			{
				Console.Write(" ");
				spaceVal = 0;
			}
		}
		Console.WriteLine();
	}
}

public class BitwiseDemo
{
	public static void Main()
	{
		Console.WriteLine("Enter a Number for Conversion to Binary Form: ");
		int num=int.Parse(Console.ReadLine());
		Convert con = new Convert(8);
		Console.WriteLine("the Number in Binary Form is: ");
		con.ConvertToBinary(num);
	}
}