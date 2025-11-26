class TestClass               // class definition
{
	public void fun()
	{
		System.Console.WriteLine("C# is modern");
	}
}

class SampleSeven
{
	public static void Main()
	{
		TestClass test =  new TestClass(); // creating test object
		test.fun(); // calling fun() function
	}
}