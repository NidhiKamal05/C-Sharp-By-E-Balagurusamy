using System;
using System.Collections.Generic;
using System.Text;
namespace jaggedArrayExample
{
	class Program
	{
		static void Main(string[] args)
		{
			const int rows = 3;
			// declare the jagged array as 3 rows high
			int[][] jagArr = new int[rows][];
			// a row with 2 elements
			jagArr[0] = new int[2];
			// a row with 3 elements
			jagArr[1] = new int[3];
			// a row with 4 elements
			jagArr[2] = new int[4];
			// Fill some (but not all) elements of the rows
			jagArr[0][1] = 54;
			jagArr[1][0] = 26;
			jagArr[1][1] = 18;
			jagArr[2][0] = 72;
			jagArr[2][3] = 404;
			for(int i=0; i<2; i++)
			{
				Console.WriteLine("This is jagged Array 1 having elements : [0][{0}] = {1}", i, jagArr[0][i]);
			}
			for(int i=0; i<3; i++)
			{
				Console.WriteLine("This is jagged Array 2 having elements : [1][{0}] = {1}", i, jagArr[1][i]);
			}
			for(int i=0; i<4; i++)
			{
				Console.WriteLine("This is jagged Array 3 having elements : [2][{0}] = {1}", i, jagArr[2][i]);
			}
		}
	}
}