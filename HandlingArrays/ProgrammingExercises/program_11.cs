using System;

class Shopping {
	static void DeleteItem(ref string[] arr, string s) {
		int index = Array.IndexOf(arr, s) ;
		if(index != -1) {
			string[] newArr = new string[arr.Length - 1] ;
			Array.Copy(arr, 0, newArr, 0, index) ;
			Array.Copy(arr, index + 1, newArr, index, arr.Length - index - 1) ;
			arr = newArr ;
		}
	}
	
	static void AddItemAtPosition(ref string[] arr, string s, int pos) {
		string[] newArr = new string[arr.Length + 1] ;
		Array.Copy(arr, 0, newArr, 0, pos) ;
		newArr[pos] = s ;
		Array.Copy(arr, pos, newArr, pos + 1, arr.Length - pos) ;
		arr = newArr ;
	}
	
	static void AddItemAtEnd(ref string[] arr, string s) {
		string[] newArr = new string[arr.Length + 1] ;
		Array.Copy(arr, 0, newArr, 0, arr.Length) ;
		newArr[arr.Length] = s ;
		arr = newArr ;
	}
	
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
			Console.WriteLine("--------------------------------------") ;
			Console.WriteLine("Original array....") ;
			PrintStr(str) ;

			DeleteItem(ref str, "Bag") ;
			Console.WriteLine("--------------------------------------") ;
			Console.WriteLine("After deleting \"Bag\"....") ;
			PrintStr(str) ;

			AddItemAtPosition(ref str, "Lipstick", 2) ;
			Console.WriteLine("--------------------------------------") ;
			Console.WriteLine("After adding \"Lipstick\" at " + 2 + "th position....") ;
			PrintStr(str) ;

			AddItemAtEnd(ref str, "Bag") ;
			Console.WriteLine("--------------------------------------") ;
			Console.WriteLine("After adding \"Bag\"....") ;
			PrintStr(str) ;
		}
	}
}