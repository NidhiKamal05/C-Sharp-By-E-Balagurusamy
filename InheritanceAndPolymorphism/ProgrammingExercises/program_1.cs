using System ;

class Animal {
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
}

class Dog : Animal
{
	
}

class Cat : Animal
{
	
}

class Program {
	public static void Main() {
		Dog dog = new Dog() ;
		Cat cat = new Cat() ;
		dog.Set("Taarzan", 5) ;
		dog.Display() ;
		cat.Set("Kiyo", 2) ;
		cat.Display() ;
	}
}