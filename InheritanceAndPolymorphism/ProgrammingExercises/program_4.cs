using System ;

class Animal {
	protected string name ;
	protected int age ;
	public void Set(string animalName, int animalAge) {
		name = animalName ;
		age = animalAge ;
	}
	public virtual void Display() {
		Console.WriteLine("\nANIMAL...") ;
		Console.WriteLine("Animal name: " + name) ;
		Console.WriteLine("Animal age: " + age) ;
	}
}

class Dog : Animal
{
	public override void Display() {
		Console.WriteLine("\nDOG...") ;
		Console.WriteLine("Animal name: " + name) ;
		Console.WriteLine("Animal age: " + age) ;
	}
}

class Cat : Animal
{
	public override void Display() {
		Console.WriteLine("\nCAT...") ;
		Console.WriteLine("Animal name: " + name) ;
		Console.WriteLine("Animal age: " + age) ;
	}
}

class Program {
	public static void Main() {
		Animal animal = new Animal() ;
		Dog dog = new Dog() ;
		Cat cat = new Cat() ;
		animal.Set("Cow", 10) ;
		animal.Display() ;
		dog.Set("Taarzan", 5) ;
		dog.Display() ;
		cat.Set("Kiyo", 2) ;
		cat.Display() ;
	}
}