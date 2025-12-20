/*using System;
class RefCheck
{
	static void ShowArray(ref int[] intArray)
	{
		if(intArray == null)
		{
			intArray = new int[10];
		}
		intArray[1] = 13;
		intArray[2] = 15;
	}
	static void Main()
	{
		int[] arrObj = {3, 5, 7, 9, 11};
		
		ShowArray(arrObj);
		
		System.Console.WriteLine("elements of the Array are:");
		for(int i = 0; i < arrObj.Length; i++)
		{
			System.Console.Write(arrObj[i] + " ");
		}
	}
}*/

using System;
class RefCheck
{
	static void ShowArray(ref int[] intArray)
	{
		if(intArray == null)
		{
			intArray = new int[10];
		}
		intArray[1] = 13;
		intArray[4] = 15;
	}
	static void Main()
	{
		int[] arrObj = {3, 5, 7, 9, 11};
		
		ShowArray(ref arrObj);
		
		Console.WriteLine("elements of the Array are:");
		for(int i = 0; i < arrObj.Length; i++)
		{
			System.Console.Write(arrObj[i] + " ");
		}
	}
}