/*using System ;
class AddOdd {
	public static void Main() {
		int sum = 0 ;
		for(int num=0; num<=20; ++num) {
			if(num % 2 != 0) {
				sum += num ;
			}
		}
		Console.WriteLine("Sum of all odd numbers from 0 to 20 is {0}", sum) ;
	}
}*/

using System ;
class AddOdd {
	public static void Main() {
		int sum = 0, num = 0 ;
		
		add:
			if(num > 20)
				goto result ;
			if(num % 2 != 0)
				sum += num ;
			++num ;
			goto add ;
			
		result:
			Console.WriteLine("Sum of all odd numbers from 0 to 20 is {0}", sum) ;
	}
}