/*using System;
class StudentRecord
{
	static void Main(string[] args)
	{
		Console.WriteLine("enter the name of the student: ");
		string name = Console.ReadLine();
		
		Console.WriteLine("Enter the grade for the student: ");
		string grade = Console.ReadLine();
		
		if(grade == "a")
			Console.WriteLine("{0} is an Outstanding student.", name);
			Console.WriteLine("You have received a scholarship.");
		else if(grade == "b")
			Console.WriteLine("{0} is a Good student.", name);
		else if(grade == "c")
			Console.WriteLine("{0} is an Average student.", name);
		else if(grade == "d")
			Console.WriteLine("{0} Needs more practice.", name);
		else
			Console.WriteLine("{0} Need a lot of practice.", name);
	}
}*/

using System;
class StudentRecord
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter the name of the student: ");
		string name = Console.ReadLine();
		
		Console.WriteLine("Enter the grade for the student: ");
		string grade = Console.ReadLine();
		
		if(grade == "a") {
			Console.WriteLine("{0} is an Outstanding student.", name);
			Console.WriteLine("You have received a scholarship.");
		}
		else if(grade == "b")
			Console.WriteLine("{0} is a Good student.", name);
		else if(grade == "c")
			Console.WriteLine("{0} is an Average student.", name);
		else if(grade == "d")
			Console.WriteLine("{0} Needs more practice.", name);
		else
			Console.WriteLine("{0} Need a lot of practice.", name);
	}
}