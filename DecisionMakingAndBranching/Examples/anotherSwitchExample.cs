using System;
class CityGuide
{
	public static void Main()
	{
		Console.WriteLine("Select your Cola Can:");
		Console.WriteLine("S=SMALL M=MEDIUM L=LARGE");
		Console.WriteLine("Please enter your option: ");
		String s = Console.ReadLine();
		int cost = 0;		
		switch(s)
		{
			case "S":
				cost += 10;
				break;
			case "M":
				cost += 15;
				goto case "S";
			case "L":
				cost += 30;
				goto case "S";
			default:
				Console.WriteLine("Invalid option, Please select either S, M, or L");
				break;
		}
		if(cost != 0)
			Console.WriteLine("Please pay {0} Rupees.", cost);
	}
}