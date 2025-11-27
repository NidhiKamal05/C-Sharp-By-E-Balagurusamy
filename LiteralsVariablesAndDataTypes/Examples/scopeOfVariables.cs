using System;
class Scope
{
	int x=10;
	static int y=20;
		public static void Main()
		{
			int x=100;
			int y=200;
			Console.WriteLine(x); // local x
			Console.WriteLine(y); // local y
			Console.WriteLine(this.x); // instance x
			Console.WriteLine(Scope.y); // static y
		}
}