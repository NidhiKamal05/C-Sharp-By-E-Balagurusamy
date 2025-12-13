using System;
class StudentMarks
{
	static void Main(string[] args)
	{
		int[] marks = new int[5];
		int totalMarks = 0;
		Console.WriteLine("==Student Information==\n");
		for(int i = 0; i < 5; i++)
		{
			Console.WriteLine("Enter Your Marks in Subject {0}: ", i+1);
			marks[i] = int.Parse(Console.ReadLine());
		}
		Console.WriteLine();
		// Displaying Student Marks
		Console.Write("The marks you have entered are: ");
		for(int i = 0; i < 5; i++)
		{
			if(i<4)
				Console.Write(marks[i] + ",");
			else
				Console.Write(marks[i]);
		}
		// Calculating and Displaying Total Marks of the Student
		for(int i = 0; i < 5; i++)
		{
			totalMarks += marks[i];
		}
		Console.WriteLine();
		Console.WriteLine("Your total marks are: {0}", totalMarks);
		// Calculating and Displaying Maximum Marks of the Student
		int maxMarks = marks[0];
		int index = 1;
		for(int i = 1; i < 5; i++)
		{
			if(marks[i] > maxMarks)
			{
				maxMarks = marks[i];
				index=i+1;
			}
		}
		Console.WriteLine("You have scored the maximum marks {0} in Subject {1}.", maxMarks,index);
		// Calculating and Displaying Minimum Marks of the Student
		int minMarks = marks[0];
		index = 1;
		for(int i = 1; i < 5; i++)
		{
			if(marks[i] < maxMarks)
			{
				minMarks = marks[i];
				index=i+1;
			}
		}
		Console.WriteLine("You have scored the minimum marks {0} in Subject {1}.", minMarks,index);
		// Calculating and Displaying Percentage of the Student
		double percentage;
		double val=0.0;
		val=(double)totalMarks / 500;
		percentage = (double)val*100;
		Console.WriteLine("Your percentage is: {0}%", percentage);
		Console.ReadLine();
	}
}