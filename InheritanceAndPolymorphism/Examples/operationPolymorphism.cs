using System;
class Dog
{
	
}
class Cat
{
	
}
class Operation
{
	static void Call (Dog d)
	{
		Console.WriteLine ("Dog is called");
	}
	static void Call (Cat c)
	{
		Console.WriteLine ("Cat is called");
	}
	public static void Main()
	{
		Dog dog = new Dog();
		Cat cat = new Cat ();
		Call(dog);   // invoking Call()
		Call(cat);   // again invoking Call()
	}
}