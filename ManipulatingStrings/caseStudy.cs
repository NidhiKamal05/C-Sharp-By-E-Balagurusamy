using System;
using System.Collections.Generic;
using System.Text;
namespace AboutStrings
{
	class Program
	{
		static void Main(string[] args)
		{
			string str1 = "", str2, str3, str4;
			Console.WriteLine("this is an example of how strings can be manipulated/validated in C#.");
			Console.WriteLine("=====================================================================");
			int n = 0;
			Console.Write("Please enter your Name : ");
			str1 = Console.ReadLine();
			if(str1.Length > 3)
			{
				if(string.IsNullOrEmpty(str1))
				{
					Console.WriteLine("string cannot be empty");
				}
				else if(char.IsNumber(str1, 0) || char.IsNumber(str1, 1) || char.IsNumber(str1, 2) || char.IsNumber(str1, 3))
				{
					Console.WriteLine("Name is a number type");
				}
				else if(char.IsLower(str1, 0))
				{
					Console.WriteLine("First character of the Name should be capital.");
				}				
				else if(char.IsUpper(str1, 1) || char.IsUpper(str1, 2) || char.IsUpper(str1, 3))
				{
					Console.WriteLine("Only the first character should be in Capital.");
				}
				else
				{
					Console.WriteLine("Correct Name inserted.");
					Console.Write("Enter your surname : ");
					str2 = Console.ReadLine();
					if(str2.Length > 3)
					{
						if(string.IsNullOrEmpty(str2))
						{
							Console.WriteLine("Surname cannot be empty");
						}
						else if(char.IsNumber(str2, 0) || char.IsNumber(str2, 1) || char.IsNumber(str2, 2) || char.IsNumber(str2, 3))
						{
							Console.WriteLine("Surname is a number type");
						}
						else if(char.IsLower(str2, 0))
						{
							Console.WriteLine("First character of the Surname should be capital.");
						}				
						else if(char.IsUpper(str2, 1) || char.IsUpper(str2, 2) || char.IsUpper(str2, 3))
						{
							Console.WriteLine("Only the first character of Surname should be in Capital.");
						}
						else
						{
							str3 = str1 + " " + str2;
							Console.WriteLine("You have entered your name as : " + str3);
							if(str3.Contains("o"))
							{
								Console.WriteLine("Your name contains 'o' charecter");
							}
							else
							{
								Console.WriteLine("Your name does not contain 'o' character");
							}
							n = string.Compare(str1, str2);
							if(n == 0)
							{
								Console.WriteLine("Your firstname and surname is equal in all respect.");
							}
							else if(n > 0)
							{
								Console.WriteLine("Your firstname is greater than your surname");
							}
							else
							{
								Console.WriteLine("Your surname is greater than your firstname");
							}
							StringBuilder sb1 = new StringBuilder("Sir/Madam ");
							Console.WriteLine("Added before your name: " + sb1.Append(str3));
							Console.WriteLine("Added in your Name: " + sb1.Insert(10, " Mr./Ms. "));
							str4 = string.Copy(str3);
							Console.WriteLine("String str4 is now having your full Name : " + str4);
							Console.WriteLine("Removing Sir/Madam from your current Name : " + sb1.Remove(0, 9));
							Console.WriteLine("Replacing Mr. with Mister we have: " + sb1.Replace("Mr.", "Mister"));
						} // End of checks for str2
					}
					else
					{
						Console.WriteLine("Surname should be at least 4 characters.");
					} // End for check of str2 length is at least 4
				} // End for check of str1 after proper output
			}
			else
			{
				Console.WriteLine("Name should be at least 4 characters.");
			} // End for check of str1 length is at least 4
		}
	}
}