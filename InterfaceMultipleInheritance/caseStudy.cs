/* How in a real lfe situation all the different properties(color, computername, price and processor)
of a single product like
	HP Computer can be stored in different methods and called separately for their use when
required */	
using System;
using System.Collections.Generic;
using System.Text;
namespace CaseStudy14
{
	interface HPSystem
	{
		void ListComputer();
		void ShowComputerColor(string str);
		void ShowComputerFeature(string feature);
		void ShowComputerPrice(double price);
	}
	class ComputerList : HPSystem
	{
		string computercolor = "";
		string computernames = "";
		public void ListComputer()
		{
			computernames = "1.	HP Pavilion Media Center m8000n";
			computernames = computernames + "\n2. HP Compaq DC5750 PC";
			computernames = computernames + "\n3. HP Compaq DX2300 PC";
			Console.WriteLine("The HP Computers are : \n\n" + computernames);
		}
		public void ShowComputerColor(string color)
		{
			this.computercolor = color;
			Console.WriteLine("\nThe color of the systems are: " + computercolor + "\n");
		}
		public void ShowComputerFeature(string feature){}
		public void ShowComputerPrice(double price){}
	}
	class ShowHPComputerDetails : ComputerList
	{
		string ComputerFeature = "";
		double ComputerPrice = 0;
		public new void ShowComputerFeature(string feature)
		{
			this.ComputerFeature = feature;
			Console.WriteLine("\nThe features of the systems are: " + ComputerFeature);
		}
		public new void ShowComputerPrice(double price)
		{
			this.ComputerPrice = price;
			Console.WriteLine("\nThe prices of the systems are: " + ComputerPrice);
		}
	}
	class ShowComputerFeatures
	{
		static void Main(string[] args)
		{
			ShowHPComputerDetails hpm = new ShowHPComputerDetails();
			hpm.ListComputer();
			hpm.ShowComputerColor("Steel Gray");
			hpm.ShowComputerColor("Black");
			hpm.ShowComputerColor("Gray");
			hpm.ShowComputerFeature("Pentium PV PC Dual Core2");
			hpm.ShowComputerFeature("Pentium PIV 2.5GHz processor");
			hpm.ShowComputerFeature("Pentium PV PC Dual Core");
			hpm.ShowComputerPrice(63000);
			hpm.ShowComputerPrice(30000);
			hpm.ShowComputerPrice(45000);
		}
	}
}