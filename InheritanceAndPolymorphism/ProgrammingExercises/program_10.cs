using System ;

class Staff {
	private string code ;
	private string name ;
	public void Init(string code, string name) {
		this.code = code ;
		this.name = name ;
	}
	public virtual void Display() {
		Console.WriteLine("Code: " + code + ", Name: " + name) ;
	}
}

class Teacher : Staff
{
	private string subject ;
	private string publication ;
	public void InitTeacher(string code, string name, string subject, string publication) {
		Init(code, name) ;
		this.subject = subject ;
		this.publication = publication ;
	}
	public override void Display() {
		base.Display() ;
		Console.WriteLine("Subject: " + subject + ", Publication: " + publication) ;
	}
}

class Typist : Staff
{
	private int speed ;
	public void InitTypist(string code, string name, int speed) {
		Init(code, name) ;
		this.speed = speed ;
	}
	public override void Display() {
		base.Display() ;
		Console.WriteLine("Speed: " + speed) ;
	}
}

class Officer : Staff
{
	private string grade ;
	public void InitOfficer(string code, string name, string grade) {
		Init(code, name) ;
		this.grade = grade ;
	}
	public override void Display() {
		base.Display() ;
		Console.WriteLine("Grade: " + grade) ;
	}
}

class Regular : Typist
{
	public void InitRegular(string code, string name, int speed) {
		InitTypist(code, name, speed) ;
	}
	public override void Display() {
		base.Display() ;
	}
}

class Casual : Typist
{
	private double dailyWages ;
	public void InitCasual(string code, string name, int speed, double dailyWages) {
		InitTypist(code, name, speed) ;
		this.dailyWages = dailyWages ;
	}
	public override void Display() {
		base.Display() ;
		Console.WriteLine("DailyWages: " + dailyWages) ;
	}
}

public class Program {
	public static void Main() {
		Casual c = new Casual() ;
		Console.WriteLine("\nCasual....") ;
		c.InitCasual("001", "abc", 23, 500) ;
		c.Display() ;
		
		Regular r = new Regular() ;
		Console.WriteLine("\nRegular....") ;
		r.InitRegular("101", "djbm", 36) ;
		r.Display() ;
		
		Officer o = new Officer() ;
		Console.WriteLine("\nOfficer....") ;
		o.InitOfficer("201", "werty", "A") ;
		o.Display() ;		
		
		Typist t = new Typist() ;
		Console.WriteLine("\nTypist....") ;
		t.InitTypist("601", "asafd", 55) ;
		t.Display() ;
		
		Teacher te = new Teacher() ;
		Console.WriteLine("\nTeacher....") ;
		te.InitTeacher("331", "vnxz", "C#", "qtsrhg") ;
		te.Display() ;
		
		Staff s = new Staff() ;
		Console.WriteLine("\nStaff....") ;
		s.Init("222", "lkjh") ;
		s.Display() ;
	}
}