/*using System;
public class StopCounter
{
	public static void Main()
	{
		for(int index = 0; index < 10; index++)
		{
			Console.WriteLine("Counter Index: {0}", index);
			if(index == 5)
			{
				{
					Console.WriteLine("Stopping and Exiting the loop.");
				}
			}
			Console.WriteLine("For loop Iteration.");
		}
	}
}*/

using System;
public class StopCounter
{
	public static void Main()
	{
		for(int index = 0; index < 10; index++)
		{
			Console.WriteLine("Counter Index: {0}", index);
			if(index == 5)
			{
				{
					Console.WriteLine("Stopping and Exiting the loop.");
					break ;
				}
			}
			Console.WriteLine("For loop Iteration.");
		}
	}
}