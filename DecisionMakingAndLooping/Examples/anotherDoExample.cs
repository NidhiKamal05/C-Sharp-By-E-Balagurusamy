using System;
class DoExample
{
	public static void Main()
	{
		string option;
		do
		{			
			Console.WriteLine("--Address Book--\n");
			
			Console.WriteLine("N - Add New Entry");
			Console.WriteLine("U - Update Entry");
			Console.WriteLine("R - Remove Entry");
			Console.WriteLine("S - Show All Entries");
			Console.WriteLine("C - Close");
			
			Console.WriteLine("Please enter Your Choice: ");
			option = Console.ReadLine();
			
			switch(option)
			{
				case "N":
				case "n":
					Console.WriteLine("You have selected the Add New Entry option.");
					break;
				case "U":
				case "u":
					Console.WriteLine("You have selected the Update Entry option.");
					break;
				case "R":
				case "r":
					Console.WriteLine("You have selected the Remove Entry option.");
					break;
				case "S":
				case "s":
					Console.WriteLine("You have selected the Show All Entries option.");
					break;
				case "C":
				case "c":
					Console.WriteLine("The program will close now..");
					break;
				default:
					Console.WriteLine("You have not entered a valid choice.", option);
					break;
			}
			Console.Write("");
			Console.ReadLine();
		}
		while(option != "C" && option != "c");
;	}
}