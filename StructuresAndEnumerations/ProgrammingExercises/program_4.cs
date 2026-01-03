using System ;

class Program {
	struct DateOfBirth {
		public int date ;
		public int month ;
		public int year ;
	}
	struct StudentRecord {
		public string name ;
		public DateOfBirth dob ;
		public int totalMarks ;
	}
	static void Main(string[] args) {
		StudentRecord s1 = new StudentRecord() ;		
		s1.name = "Rita Sharma" ;
		s1.dob.date = 20 ;
		s1.dob.month = 11 ;
		s1.dob.year = 2003 ;
		s1.totalMarks = 450 ;
		
		Console.WriteLine("Student Detail...");
		Console.WriteLine("-----------------");
		Console.WriteLine("Name: " + s1.name);
		Console.WriteLine("DOB: " + s1.dob.date + "." + s1.dob.month + "." + s1.dob.year);
		Console.WriteLine("Total marks obtained: " + s1.totalMarks);
	}
}