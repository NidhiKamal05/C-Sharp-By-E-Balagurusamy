using System ;
class Program {
	public static void Main() {
		
		Console.Write("Enter total amt of mill clothes = ") ;
		double mill = double.Parse(Console.ReadLine());
		
		Console.Write("Enter total amt of handloom items = ") ;
		double handloom = double.Parse(Console.ReadLine());
		
		double millDis = 0, handloomDis = 0 ;
		
		if(mill >= 0 && mill <= 100) {
			millDis = 0 ;
		}
		else if(mill >= 101 && mill <= 200) {
			millDis = 5 ;
		}
		else if(mill >= 201 && mill <= 300) {
			millDis = 7.5 ;
		}	
		else {
			millDis = 10 ;
		}
		
		if(handloom >= 0 && handloom <= 100) {
			handloomDis = 5 ;
		}
		else if(handloom >= 101 && handloom <= 200) {
			handloomDis = 7.5 ;
		}
		else if(handloom >= 201 && handloom <= 300) {
			handloomDis = 10 ;
		}	
		else {
			handloomDis = 15 ;
		}
		
		double totalMill = mill - ((millDis / 100) * mill) ;
		double totalHandloom = handloom - ((handloomDis / 100) * handloom) ;
		
		Console.WriteLine("Net amt to be paid by a customer = {0}", (totalMill + totalHandloom)) ;
		
	}
}