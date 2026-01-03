using System ;

class Program {
	struct MailingList {
		public string name ;
		public string doorNumber ;
		public string street ;
		public string city ;
		public string pincode ;
	}
	static void Main(string[] args) {
		MailingList m = new MailingList() ;
		Console.WriteLine("Enter...") ;
		Console.Write("Name: ") ;
		m.name = Console.ReadLine() ;
		Console.Write("Door Number: ") ;
		m.doorNumber = Console.ReadLine() ;
		Console.Write("Street: ") ;
		m.street = Console.ReadLine() ;
		Console.Write("City: ") ;
		m.city = Console.ReadLine() ;
		Console.Write("Pincode: ") ;
		m.pincode = Console.ReadLine() ;		
		
		Console.WriteLine() ;
		Console.WriteLine("Mailing Detail...");
		Console.WriteLine("-----------------");
		Console.WriteLine("Name: " + m.name);
		Console.WriteLine("Door Number: " + m.doorNumber);
		Console.WriteLine("Street: " + m.street);
		Console.WriteLine("City: " + m.city);
		Console.WriteLine("Pincode: " + m.pincode);
	}
}