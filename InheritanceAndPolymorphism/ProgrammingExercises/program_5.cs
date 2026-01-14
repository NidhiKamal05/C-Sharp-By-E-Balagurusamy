using System ;

abstract class Animal {
	string name ;
	int age ;
	public void Set(string animalName, int animalAge) {
		name = animalName ;
		age = animalAge ;
	}
	public void Display() {
		Console.WriteLine("\nAnimal name: " + name) ;
		Console.WriteLine("Animal age: " + age) ;
	}
	public abstract void Sound() ;
}

class Dog : Animal
{
	public override void Sound() {
		Console.WriteLine("Dog's sound....") ;
	}
}

class Cat : Animal
{
	public override void Sound() {
		Console.WriteLine("Cat's sound....") ;
	}
}

class Program {
	public static void Main() {
		Dog dog = new Dog() ;
		Cat cat = new Cat() ;
		dog.Set("Taarzan", 5) ;
		dog.Display() ;
		dog.Sound() ;
		cat.Set("Kiyo", 2) ;
		cat.Display() ;
		dog.Sound() ;
	}
}