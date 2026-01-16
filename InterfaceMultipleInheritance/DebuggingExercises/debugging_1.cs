using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp1_chap14
{
	public abstract class Car
	{
		public abstract void RemoveAllFuses();
		public abstract void StartEngine();
	}
	class Seat : Car
	{
		public override void RemoveAllFuses()
		{
			
		}
		public override void StartEngine()
		{
			
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Seat c = new Seat();
			c.RemoveAllFuses();
		}
	}
}




/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp1_chap14
{
	public abstract class Car
	{
		abstract void RemoveAllFuses();
		abstract void StartEngine();
	}
	class Seat : Car
	{
		public override void RemoveAllFuses()
		{
			
		}
		public override void StartEngine()
		{
			
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Seat c = new Seat();
			c.RemoveAllFuses();
		}
	}
}*/