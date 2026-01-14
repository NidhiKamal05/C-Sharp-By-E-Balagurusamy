using System;
using System.Collections.Generic;
using System.Text;
namespace PolymorphismExample
{
	class PolymorphismDemo
	{
		static void Main(string[] args)
		{
			Automobile a = new Automobile();
			a.PowerSource = "100 H.P.";
			a.IncreaseVelocity(60);
			BMW car = new BMW();
			car.Color("Black");
			Console.WriteLine("\nPress Enter to exit...");
			Console.ReadLine();
		}
	}
	class Vehicle {
		string Vehiclepower = "";
		public string PowerSource
		{
			set
			{
				Vehiclepower = value;
				Console.WriteLine("Power of engine is set to \"{0}\"", value.ToString());
			}
			get
			{
				return Vehiclepower;
			}
		} // end property PowerSource
		public virtual void IncreaseVelocity(int i)
		{
			Console.WriteLine("The speed increases to " + i.ToString() + " m.p.h.");
		} // end method IncreaseVelocity
	} // end of base class Vehicle
	class Automobile : Vehicle
	{
		public override void IncreaseVelocity(int i)
		{
			if (i > 120)
			{
				// an automobile shouldn't be going that fast, so reducing the speed to 120 m.p.h.
				i = 120;
			}
			Console.WriteLine("You press the accelerator of the automobile, increasing its speed to {0}", i.ToString() + " m.p.h.");
		}
		public virtual void Color(string col)
		{
			col = "Blue";
			Console.Write("The color of BMW is ");
			Console.WriteLine(col);
		} // end method Color
	} // end derived class Automobile
	class BMW : Automobile
	{
		public override void Color(string col)
		{
			col = "Navy";
			Console.Write("The color of BMW is ");
			Console.WriteLine(col);
		}
	} // end derived class BMW
}