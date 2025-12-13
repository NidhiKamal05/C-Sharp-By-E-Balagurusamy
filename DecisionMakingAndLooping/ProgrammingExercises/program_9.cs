using System;
class IllustrationOfForeach {
	public static void Main() {
		string[] students = {"Ram", "Shyam", "Sita", "Gita"} ;
		Console.WriteLine("List of students in a group....") ;
		foreach(String student in students) {
			Console.WriteLine(student) ;
		}
	}
}