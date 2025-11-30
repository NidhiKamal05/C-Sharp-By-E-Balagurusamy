using System;
class BitwiseOperator
{
	public static void Main()
	{
		byte bwAnd, bwOr, bwXor;
		int bwLeft, bwRight, bwComp ;
		bwAnd = 15 & 3;
		bwOr = 15 | 3;
		bwXor = 15 ^ 3;
		bwLeft = 15 << 5;
		bwRight = 15 >> 3;
		bwComp = -15;
		System.Console.WriteLine("--To demonstrate the use of Bitwise Operators available in C#--\n");
		System.Console.WriteLine("Bitwise AND Operator Result: = {0} \nBitwise OR Operator Result: = {1}", bwAnd, bwOr);
		System.Console.WriteLine("Bitwise XOR Operator Result: = {0} \nBitwise SHIFT LEFT Operator Result: = {1}", bwXor, bwLeft);
		System.Console.WriteLine("Bitwise SHIFT RIGHT Operator Result: = {0} \nBitwise ONE'S COMPLEMENT Operator Result: = {1}", bwRight, bwComp);		
	}
}