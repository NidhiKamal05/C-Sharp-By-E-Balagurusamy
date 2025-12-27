using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AddStudentDetails
{
	class StudentDetails
	{
		static void Main(string[] args)
		{
			string studname1, studname2, studname3;
			string classname1, classname2, classname3;
			string rollno1, rollno2, rollno3;
			string getresult;
			
			ArrayList arrlist = new ArrayList();
			
			Console.WriteLine("The initial capacity of arraylist = " + arrlist.Capacity);
			Console.WriteLine("The initial elements are = " + arrlist.Count);
			
			Console.WriteLine("Enter Details of Student 1");
			Console.WriteLine("----------------------------------");
			Console.Write("Enter Name of Student1: ");
			studname1 = Console.ReadLine();
			Console.Write("Enter Class of Student1: ");
			classname1 = Console.ReadLine();
			Console.Write("Enter Roll No. of Student1: ");
			rollno1 = Console.ReadLine();
			Console.WriteLine("----------------------------------");
			
			Console.WriteLine("Enter Details of Student 2");
			Console.WriteLine("----------------------------------");
			Console.Write("Enter Name of Student2: ");
			studname2 = Console.ReadLine();
			Console.Write("Enter Class of Student2: ");
			classname2 = Console.ReadLine();
			Console.Write("Enter Roll No. of Student2: ");
			rollno2 = Console.ReadLine();
			Console.WriteLine("----------------------------------");
			
			Console.WriteLine("Enter Details of Student 3");
			Console.WriteLine("----------------------------------");
			Console.Write("Enter Name of Student3: ");
			studname3 = Console.ReadLine();
			Console.Write("Enter Class of Student3: ");
			classname3 = Console.ReadLine();
			Console.Write("Enter Roll No. of Student3: ");
			rollno3 = Console.ReadLine();
			Console.WriteLine("----------------------------------");
			
			arrlist.Add(studname1);
			arrlist.Add(classname1);
			arrlist.Add(rollno1);
			arrlist.Add(studname2);
			arrlist.Add(classname2);
			arrlist.Add(rollno2);
			arrlist.Add(studname3);
			arrlist.Add(classname3);
			arrlist.Add(rollno3);
			
			Console.WriteLine("Current Capacity = " + arrlist.Capacity);
			Console.WriteLine("ArrayList having elements = " + arrlist.Count);
			
			Console.WriteLine("ArrayList is having content:-");
			for(int i=0; i<arrlist.Count; i++)
			{
				Console.Write(arrlist[i] + " ");
			}
			Console.WriteLine("\n");
			
			Console.WriteLine("To remove 2nd student details press y or to interchange student details1 with student details3 press n.");
			getresult = Console.ReadLine();
			
			if(getresult == "y")
			{
				Console.WriteLine("Removing 2nd Student details");
				Console.WriteLine("------------------------------");
				arrlist.Remove(studname2);
				arrlist.Remove(classname2);
				arrlist.Remove(rollno2);
				Console.WriteLine("Current Capacity of the arraylist is now = " + arrlist.Capacity);
				Console.WriteLine("ArrayList having elements = " + arrlist.Count);
				Console.WriteLine("The elements of arraylist are now:- ");
				for(int m=0; m<arrlist.Count; m++)
				{
					Console.Write(arrlist[m] + " ");
				}
				Console.WriteLine("\n");
			}
			else
			{
				Console.WriteLine("\n");
				Console.WriteLine("Changing elements");
				Console.WriteLine("-----------------------------");
				arrlist[0] = studname3.ToString();
				arrlist[1] = classname3;
				arrlist[2] = rollno3;
				arrlist[6] = studname1;
				arrlist[7] = classname1;
				arrlist[8] = rollno1;
				Console.WriteLine("Now the elements of the Arraylist are : ");
				for(int m=0; m<arrlist.Count; m++)
				{
					Console.Write(arrlist[m] + " ");
				}
				Console.WriteLine("\n");
			}
		}
	}
}