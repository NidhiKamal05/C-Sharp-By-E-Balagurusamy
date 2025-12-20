class Mult
{
	public void Multiply(ref int first, ref int second, out int result)
	{
		result=first*second;
	}
	public void Multiply(ref float first, ref float second, out float result)
	{
		result=first*second;
	}
}
public class MethodsExample
{
	public static void Main()
	{
		Mult multObj = new Mult();
		int intFirst = 33;
		int intSecond = 5;
		int intResult = 0;
		System.Console.WriteLine("Integer Values Before Multiplication:");
		System.Console.WriteLine("\tFirst Integer: {0}\n\tSecond Integer: {1}\n\tInteger Result: {2}", intFirst, intSecond, intResult);
		multObj.Multiply(ref intFirst, ref intSecond, out intResult);
		System.Console.WriteLine("Integer Values After Multiplication:");
		System.Console.WriteLine("\tFirst Integer: {0}\n\tSecond Integer: {1}\n\tInteger Result: {2}", intFirst, intSecond, intResult);
		float floatFirst = 33f;
		float floatSecond = 5f;
		float floatResult = 0f;
		System.Console.WriteLine("Float Values Before Multiplication:");
		System.Console.WriteLine("\tFirst Float: {0}\n\tSecond Float: {1}\n\tFloat Result: {2}", floatFirst, floatSecond, floatResult);
		multObj.Multiply(ref floatFirst, ref floatSecond, out floatResult);
		System.Console.WriteLine("Float Values After Multiplication:");
		System.Console.WriteLine("\tFirst Float: {0}\n\tSecond Float: {1}\n\tFloat Result: {2}", floatFirst, floatSecond, floatResult);
	}
}