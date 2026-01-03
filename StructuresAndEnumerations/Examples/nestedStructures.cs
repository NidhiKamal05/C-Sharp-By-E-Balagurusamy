using System;
using System.Collections.Generic;
using System.Text;
namespace NestedStructures
{
	struct student
	{
		public string studentname;
		public string rollno;
		public static string grade;
		
		// Setting the property with struct student
		public string RollNo
		{
			set
			{
				rollno = "S000018_ClassV";
			}
			get{
				return rollno;
			}
		}
		
		// Declaring a class school with in the structure student
		public class school
		{
			public string schoolname;
			public string classname;
			// Setting property for schoolproperty
			public string schoolproperty
			{
				set
				{
					schoolname = value;
				}
				get
				{
					return schoolname;
				}
			}
			public school()
			{
				schoolname = "St. Johns School, Janakpuri, Delhi";
				classname = "Class Vth";
			}
			public void insert_details(string str1, string str2)
			{
				schoolname = str1;
				classname = str2;
			}
			public void show_details()
			{
				Console.WriteLine("School Name is {0}", schoolname);
				Console.WriteLine("Class is {0}", classname);
			}
		} // End of inner class school
		
		public struct teachers
		{
			public string tcode;
			public string tname;
			public void getValues(string st, string str)
			{
				grade = "PGT";
				tcode = st;
				tname = str;
			}
			public void show()
			{
				Console.WriteLine("Teacher Code is {0}", tcode);
				Console.WriteLine("Teacher Name is {0}", tname);
			}
		}
		// End of nested structure
		// Here method overloading applicable for the function addStudents() and addstudents(string str3, string str4)
		public void addStudents()
		{
			studentname = "Suresh Goyal";
			rollno = "S0011_class4";
		}
		public void addstudents(string str3, string str4)
		{
			studentname = str3;
			rollno = str4;
		}
		public void show()
		{
			Console.WriteLine("Student Name is {0}", studentname);
			Console.WriteLine("Roll Number is {0}", rollno);
		}
	}; // End of Structure student
	
	class Program
	{
		static void Main(string[] args)
		{
			// creating an instance of student
			student st = new student();
			st.RollNo = "S0007_Class3";
			Console.WriteLine("Roll Number after overriding the property {0}", st.RollNo);
			
			// creating an instance of inner structure teachers
			student.teachers te = new student.teachers();
			// Directly Refering the fields of inner structure teachers
			te.tcode = "T00014";
			te.tname = "Kishan Singh";
			// te.show();
			// Accessing the getValues() of inner structure teachers
			te.getValues("T00015", "Naresh Kumar");
			// calling the show() of inner structure of teachers
			te.show();
			// overriding the instance of student.teachers
			student.teachers intf1 = new student.teachers();
			intf1.getValues("T00014", "Sunil Mohan");
			intf1.show();
			// creating the instance of the nested class examination
			student.school ee = new student.school();
			ee.schoolproperty = "St. Johns School, Janakpuri, Delhi";
			ee.show_details();
		}
	}
}