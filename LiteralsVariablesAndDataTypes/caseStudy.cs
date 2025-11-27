using System;
public class CurrencyConvertor
{
	static void Main(string[] args)
	{
		int num=Int32.Parse(args[0]);
		double poundValue=(double)num*83.2;
		double dollarValue=(double)num*40;
		Console.WriteLine("==Currency Convertor==\n");
		Console.WriteLine("Currency Data Formatted Using the # character\n");
		Console.WriteLine("\tRupee Amount : {0, 0:Rs ###.##}", num);
		Console.WriteLine("\tUSD Value : {0, 0:$ ###.##}", dollarValue);
		Console.WriteLine("\tGBP Value : {0, 0:Euro ###.##}", poundValue);
		Console.WriteLine("Currency Data Formatted Using the $ character\n");
		Console.WriteLine("\tRupee Amount : {0, 0:Rs 000.00}", num);
		Console.WriteLine("\tUSD Value : {0, 0:$ 000.00}", dollarValue);
		Console.WriteLine("\tGBP Value : {0, 0:Euro 000.00}", poundValue);
		Console.WriteLine("Currency Data Formatted Using the comma only\n");
		Console.WriteLine("\tRupee Amount : {0, 0:Rs 000,000}", num);
		Console.WriteLine("\tUSD Value : {0, 0:$ 0,000.000}", dollarValue);
		Console.WriteLine("\tGBP Value : {0, 0:Euro 0,000.000}", poundValue);
	}
}