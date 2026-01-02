using System ;
class StringMethod
{
	public static void Main()
	{
		string s1 = "Lean" ;
		string s2 = s1.Insert(3, "r");          // s2 = Learn
		string s3 = s2.Insert(5, "er");         // s3 = Learner
		for(int i = 0; i < s3.Length; i++)
			Console.Write(s3[i]);
		Console.WriteLine() ;
		// Console.WriteLine(s3) ;
	}
}