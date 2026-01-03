using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp1_chap11
{
	enum Students : byte
	{
		passed,
		failed
	}
	struct Stud
	{
		public Students stu;
		public string id;
	}
	class Program
	{
		static void Main(string[] args)
		{
			Stud st = new Stud();
			st.stu = Students.passed;
			st.id = "S00017_Class5";
			Console.WriteLine("You have ");
			Console.WriteLine(st.stu);
			Console.Write("Your roll number is : ");
			Console.WriteLine(st.id);
		}
	}
}


/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp1_chap11
{
	enum Students : byte
	{
		passed,
		failed
	}
	struct Stud
	{
		Students stu;
		int id;
	}
	class Program
	{
		static void Main(string[] args)
		{
			Stud st = new Stud();
			st.stu = Students.passed;
			st.id = "S00017_Class5";
			Console.WriteLine("You have ");
			Console.WriteLine(st.stu);
			Console.Write("Your roll number is : ");
			Console.WriteLine(st.id);
		}
	}
}*/