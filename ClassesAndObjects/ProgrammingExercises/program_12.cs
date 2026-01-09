using System ;

class BankAccount {
	string accHolder ;
	string accNo ;
	string typeOfAcc ;
	double balance ;
	
	public void Assign(string name, string acc, string type, double amt) {
		accHolder = name ;
		accNo = acc ;
		typeOfAcc = type ;
		balance = amt ;
	}
	
	public void Deposit(double amt) {
		balance += amt ;
		Console.WriteLine("Deposit Successful....") ;
	}
	
	public void Withdraw(double amt) {
		if(amt > balance) {
			Console.WriteLine("Balance is not sufficient....") ;
			return ;
		}
		if(balance - amt < 100) {
			Console.WriteLine("Less than minimum balance....") ;
			return ;
		}
		balance -= amt ;
		Console.WriteLine("Withdrawl Successful....") ;
	}
	
	public void Display() {
		Console.WriteLine("Name: " + accHolder) ;
		Console.WriteLine("Balance: " + balance) ;
	}
}

class Test {
	public static void Main() {
		int customers = 10 ;
		BankAccount[] b = new BankAccount[customers] ;
		
		for(int i=0; i<customers; ++i) {
			b[i] = new BankAccount() ;
			Console.WriteLine("***************************") ;
			
			Console.WriteLine("Customer " + (i+1)) ;
			Console.WriteLine("----------") ;
			
			Console.Write("Enter name: ") ;
			string name = Console.ReadLine() ;
			Console.Write("Enter account number: ") ;
			string accNo = Console.ReadLine() ;
			Console.Write("Enter type of account: ") ;
			string type = Console.ReadLine() ;
			Console.Write("Enter balance: ") ;
			double amt = double.Parse(Console.ReadLine()) ;
			
			b[i].Assign(name, accNo, type, amt) ;
			b[i].Display() ;
		
			Console.WriteLine() ;
			
			Console.WriteLine("Enter deposit amt....") ;
			amt = double.Parse(Console.ReadLine()) ;
			b[i].Deposit(amt) ;
			b[i].Display() ;
			
			Console.WriteLine() ;
			
			Console.WriteLine("Enter withdrawl amt....") ;
			amt = double.Parse(Console.ReadLine()) ;			
			b[i].Withdraw(amt) ;
			b[i].Display() ;
			
			Console.WriteLine() ;
		}
	}
}