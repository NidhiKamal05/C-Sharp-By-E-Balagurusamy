using System;
using System.Collections;
class Inventory
{
	string partName;
	double partPrice;
	int priceQty;
	public Inventory(string pName, double pPrice, int pQty)
	{
		partName = pName;
		partPrice = pPrice;
		priceQty = pQty;
		Console.WriteLine("\nPART NAME : {0, -10}", partName);
		Console.WriteLine("\nPrice : Rs.{0, 5}\n\tQuantity: {1}", partPrice, priceQty);
	}
}
public class stockData
{
	public static void Main()
	{
		Console.WriteLine("==ABC Spare Parts ltd. Stock List==");
		new Inventory("Bolts", 2.25, 100);
		new Inventory("Shockers", 5.25, 30);
		new Inventory("Brake Pads", 3.50, 50);
		new Inventory("Steering", 120, 20);
	}
}