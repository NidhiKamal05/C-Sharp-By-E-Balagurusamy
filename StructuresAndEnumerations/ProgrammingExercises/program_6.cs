using System ;

class Program {
	struct InventoryRecord {
		public string itemCode ;
		public string itemName ;
		public double itemCost ;
		public int totalItemsAvailable ;
	}
	static void Main(string[] args) {
		int size = 5 ;
		InventoryRecord[] arr = new InventoryRecord[size] ;
		
		for(int i=0; i<size; ++i) {
			Console.WriteLine("Enter " + (i+1) + "th record...") ;
			Console.Write("Item name: ") ;
			arr[i].itemName = Console.ReadLine() ;
			Console.Write("Item code: ") ;
			arr[i].itemCode = Console.ReadLine() ;
			Console.Write("Item cost: ") ;
			arr[i].itemCost = double.Parse(Console.ReadLine()) ;
			Console.Write("Number of items available: ") ;
			arr[i].totalItemsAvailable = int.Parse(Console.ReadLine()) ;
			Console.WriteLine() ;
		}		
		
		Console.WriteLine() ;
		Console.WriteLine("{0,-10} | {1,-15} | {2,-10} | {3,-10}", "Code", "Name", "Cost", "Total Items");
		Console.WriteLine("--------------------------------------------------------") ;
		foreach(InventoryRecord a in arr) {
			Console.WriteLine("{0,-10} | {1,-15} | {2,-10:F2} | {3,-10}", a.itemCode, a.itemName, a.itemCost, a.totalItemsAvailable);
			Console.WriteLine() ;
		}
	}
}