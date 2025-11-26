using System;
class CommandLineExample
{
	static void Main(string[] args)
	{
		double argValue=0.0;
		double sqrtValue=0.0;
		if(args.Length == 0)
		{
			Console.WriteLine("No argument has been specified.");
			Console.ReadLine();
			return;
		}
		argValue = double.Parse(args[0].ToString());
		sqrtValue = Math.Sqrt(argValue);
		Console.WriteLine("--Demonstrating Command Line arguments--\n");
		Console.WriteLine("Sqaure root of the Argument is: {0}\n", sqrtValue);
	}
}