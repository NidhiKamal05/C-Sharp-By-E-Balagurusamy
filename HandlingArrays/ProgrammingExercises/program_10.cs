using System;
class Shopping {
	static void PrintStr(string[] str) {
		foreach(string s in str) {
			Console.WriteLine(s) ;
		}
	}
	public static void Main(string[] args) {
		if(args.Length == 0) {
			Console.WriteLine("No command line input....");
		}
		else {
			int l = args.Length ;
			string[] str = new string[l] ;
			for(int i=0; i<l; ++i) {
				str[i] = args[i] ;
			}
			PrintStr(str) ;
		}
	}
}