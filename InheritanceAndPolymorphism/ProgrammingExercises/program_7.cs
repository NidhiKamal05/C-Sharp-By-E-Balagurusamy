using System ;

class Person {
	protected string name ;
	protected int age ;
	protected string sex ;
}

class Employee : Person
{
	public Employee(string n, int a, string s) {
		name = n ;
		age = a ;
		sex = s ;
	}
	public void Display() {
		Console.WriteLine("\nEmployee.....") ;
		Console.WriteLine("Name: " + name) ;
		Console.WriteLine("Age: " + age) ;
		Console.WriteLine("Sex: " + sex) ;
	}
}

class Specialist : Employee
{
	public Specialist(string n, int a, string s) : base(n, a, s)
	{
		
	}
	public new void Display() {
		Console.WriteLine("\nSpecialist.....") ;
		Console.WriteLine("Name: " + name) ;
		Console.WriteLine("Age: " + age) ;
		Console.WriteLine("Sex: " + sex) ;
	}
}

class Driver
{
	public static void Main() {
		Employee[] emp = new Employee[3] ;
		emp[0] = new Employee("Abc", 55, "male") ;
		emp[1] = new Employee("Cde", 25, "female") ;
		emp[2] = new Employee("Efg", 35, "male") ;
		
		Specialist[] spec = new Specialist[3] ;
		spec[0] = new Specialist("Xyz", 40, "male") ;
		spec[1] = new Specialist("Uvw", 27, "female") ;
		spec[2] = new Specialist("Rst", 30, "female") ;
		
		Employee[] p = new Specialist[3] ;
		p[0] = new Specialist("X", 36, "female") ;
		p[1] = new Specialist("U", 29, "male") ;
		p[2] = new Specialist("R", 24, "female") ;
		
		emp[0].Display() ;
		emp[1].Display() ;
		emp[2].Display() ;
		
		spec[0].Display() ;
		spec[1].Display() ;
		spec[2].Display() ;
		
		p[0].Display() ;
		p[1].Display() ;
		p[2].Display() ;
	}
}