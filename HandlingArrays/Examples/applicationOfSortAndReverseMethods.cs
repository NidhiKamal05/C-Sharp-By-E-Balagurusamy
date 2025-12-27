using System;
using System.Collections;
using System.Text;
namespace ArraySort_ReverseExample
{
	class Program
	{
		public static void ArrDisplay(string[] arr1)
		{
			foreach(string str in arr1)
			{
				Console.WriteLine("Value: {0}", str);
			}
			Console.WriteLine("\n");
		}
		static void Main(string[] args)
		{
			String[] arr2 =
			{
				"John", "Norman", "Greg", "Steve", "Victor", "Logan"
			};
			ArrDisplay(arr2);
			Array.Reverse(arr2);
			Console.WriteLine("Here array is reversed.");
			ArrDisplay(arr2);
			String[] arr3 =
			{
				"this", "is", "an", "example",
				"of", "an", "array", "and", "how", "to", "sort", "it", "alphabetically"
			};
			ArrDisplay(arr3);
			Console.WriteLine("Now array is sorted alphabetically.");
			Array.Sort(arr3);
			ArrDisplay(arr3);
		}
	}
}