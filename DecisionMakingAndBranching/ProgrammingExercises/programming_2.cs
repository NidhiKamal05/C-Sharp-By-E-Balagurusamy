/*using System ;
class AddOddAndEven {
	public static void Main() {
		int sumOdd = 0, sumEven = 0 ;
		for(int num=0; num<=20; ++num) {
			if(num % 2 != 0) {
				sumOdd += num ;
			}			
			if(num % 2 == 0) {
				sumEven += num ;
			}
		}
		Console.WriteLine("Sum of all odd numbers from 0 to 20 is {0}", sumOdd) ;
		Console.WriteLine("Sum of all even numbers from 0 to 20 is {0}", sumEven) ;
	}
}*/

using System ;
class AddOddAndEven {
	public static void Main() {
		int sumOdd = 0, sumEven = 0, num = 0 ;
		
		add:
			if(num > 20)
				goto result ;
			if(num % 2 != 0)
				sumOdd += num ;			
			if(num % 2 == 0)
				sumEven += num ;
			++num ;
			goto add ;
			
		result:
			Console.WriteLine("Sum of all odd numbers from 0 to 20 is {0}", sumOdd) ;
			Console.WriteLine("Sum of all even numbers from 0 to 20 is {0}", sumEven) ;
	}
}