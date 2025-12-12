/*using System ;
class DivisibleBy7 {
	public static void Main() {
		int sum = 0, cnt = 0 ;
		for(int num=101; num<200; ++num) {
			if(num % 7 == 0) {
				++cnt ;
				sum += num ;
			}
		}
		Console.WriteLine("Sum of all integers greater than 100 and less than 200 that are divisible by 7 is {0}", sum) ;
		Console.WriteLine("Number of all integers greater than 100 and less than 200 that are divisible by 7 is {0}", cnt) ;
	}
}*/

using System ;
class DivisibleBy7 {
	public static void Main() {
		int sum = 0, cnt = 0, num = 101 ;
		
		label:
			if(num == 200)
				goto result ;		
			if(num % 7 == 0) {
				++cnt ;
				sum += num ;
			}
			++num ;
			goto label ;
			
		result:			
			Console.WriteLine("Sum of all integers greater than 100 and less than 200 that are divisible by 7 is {0}", sum) ;
			Console.WriteLine("Number of all integers greater than 100 and less than 200 that are divisible by 7 is {0}", cnt) ;
	}
}