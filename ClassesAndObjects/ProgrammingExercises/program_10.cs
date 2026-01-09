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
		BankAccount b = new BankAccount() ;
		
		b.Assign("Mr. Abc", "123456789012", "savings", 1000) ;
		b.Display() ;
		
		Console.WriteLine() ;
		
		b.Deposit(100) ;
		b.Display() ;
		
		Console.WriteLine() ;
		
		b.Withdraw(1050) ;
		b.Display() ;
		
		Console.WriteLine() ;
		
		b.Withdraw(500) ;
		b.Display() ;
		
		Console.WriteLine() ;
	}
}