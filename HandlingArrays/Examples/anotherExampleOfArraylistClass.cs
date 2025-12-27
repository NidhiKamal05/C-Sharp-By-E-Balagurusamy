using System;
using System.Collections;
using System.Text;
namespace ArrayListExample
{
	class Program
	{
		static void Main(string[] args)
		{
			ArrayList arr = new ArrayList();
			
			Console.WriteLine("arr ArrayList having capacity: " + arr.Capacity);
			Console.WriteLine("arr ArrayList having elements: " + arr.Count);
			Console.WriteLine();
			
			Console.WriteLine("Adding 10 prime number in the ArrayList arr.");
			arr.Add(2);
			arr.Add(3);
			arr.Add(5);
			arr.Add(7);
			arr.Add(11);
			arr.Add(13);
			arr.Add(17);
			arr.Add(19);
			arr.Add(23);
			arr.Add(29);
			
			Console.WriteLine("Now the capacity of the ArrayList is: " + arr.Capacity);
			Console.WriteLine("The number of elements in the ArrayList are: " + arr.Count);
			
			Console.Write("Elements of the ArrayList are : ");
			for(int a=0; a<arr.Count; a++)
				Console.Write(arr[a] + " ");
			Console.WriteLine("\n");
			
			Console.WriteLine("Now removing 2 elements of the ArrayList from the starting position.");
			arr.Remove(2);
			arr.Remove(3);
			
			Console.WriteLine("The capacity of the ArrayList is now: " + arr.Capacity);
			Console.WriteLine("Number of elements present in the ArrayList become: " + arr.Count);
			
			Console.Write("Elements in the ArrayList after 2 elements are removed : ");
			foreach(int m in arr)
				Console.Write(m + " ");
			Console.WriteLine("\n");
			
			Console.WriteLine("Replacing first 2 elements of the ArrayList with prime numbers 31, 37 and replacing last 2 elements with prime numbers 41, 43.");
			arr[0] = 31;
			arr[1] = 37;
			arr[6] = 41;
			arr[7] = 43;
			
			Console.Write("Now the elements of the ArrayList are : ");
			foreach(int m in arr)
				Console.Write(m + " ");
			Console.WriteLine();
		}
	}
}