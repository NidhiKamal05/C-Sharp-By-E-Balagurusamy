using System ;

class Program {
	struct StudentRecord {
		public string name ;
		public DateTime dateOfBirth ;
		public int totalMarks ;
	}
	struct MailingList {
		public string name ;
		public string doorNumber ;
		public string street ;
		public string city ;
		public string pincode ;
	}	
	struct BookRecord {
		public string author ;
		public string title ;
		public int yearOfPublication ;
		public double cost ;
	}
	struct InventoryRecord {
		public string itemCode ;
		public string itemName ;
		public double itemCost ;
		public int totalItemsAvailable ;
	}
	static void Main(string[] args) {
		Console.Write("Program Structure") ;
	}
}