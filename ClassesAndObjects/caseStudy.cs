using System;
using System.Collections.Generic;
using System.Text;
namespace CaseStudy12
{
	public class AppleComputer
	{
		private string applevariety = "";
		public AppleComputer(string appleComputerVariety)
		{
			this.applevariety = appleComputerVariety;
		}
		public void showAppleComputers()
		{
			System.Console.WriteLine(applevariety);
		}
	}
	public class HPComputer
	{
		private string hpvariety = "";
		public HPComputer(string hpComputerVariety)
		{
			this.hpvariety = hpComputerVariety;
		}
		public void showHPComputers()
		{
			System.Console.WriteLine(hpvariety);
		}
	}
	public class AcerComputer
	{
		private string acervariety = "";
		public AcerComputer(string acerComputerVariety)
		{
			this.acervariety = acerComputerVariety;
		}
		public void showAcerComputers()
		{
			System.Console.WriteLine(acervariety);
		}
	}
	class DisplayComputers
	{
		static void Main()
		{
			Console.WriteLine("This is an example of Classes and objects and how real world scenarios.");
			
			AppleComputer mac = new AppleComputer("Apple Power Mac G5");
			AppleComputer gra = new AppleComputer("Apple iMac 2 G4");
			Console.WriteLine("--------------");
			Console.WriteLine("Apple Computer varities are : ");
			mac.showAppleComputers();
			gra.showAppleComputers();
			
			HPComputer obj1 = new HPComputer("HP Pavilion Media Center m8000n");
			HPComputer obj2 = new HPComputer("HP Compaq DC5750 PC");
			Console.WriteLine("--------------");
			Console.WriteLine("HP Computer varities are : ");
			obj1.showHPComputers();
			obj2.showHPComputers();
			
			AcerComputer acObj1 = new AcerComputer("Acer Aspire E380 PC");
			AcerComputer acObj2 = new AcerComputer("Acer Aspire E560 PC");
			AcerComputer acObj3 = new AcerComputer("Acer Aspire T180 PC");
			AcerComputer acObj4 = new AcerComputer("Acer Aspire T660 PC");
			Console.WriteLine("--------------");
			Console.WriteLine("Acer Computer varities are : ");
			acObj1.showAcerComputers();
			acObj2.showAcerComputers();
			acObj3.showAcerComputers();
			acObj4.showAcerComputers();
			
			Console.WriteLine("--------------");
		}
	}
}