using System;
class MulTable
{
	static int ROWS = 20;
	static int COLUMNS = 20;
	public static void Main()
	{
		int[,] product = new int[ROWS, COLUMNS];
		Console.WriteLine("MULTIPLICATION TABLE");
		Console.WriteLine(" ");
		int i, j;
		for(i=10; i<ROWS; i++)
		{
			for(j=10; j<COLUMNS; j++)
			{
				product[i,j] = i * j ;
				Console.Write(" " + product[i,j]);
			}
			Console.WriteLine(" ");
		}
	}
}