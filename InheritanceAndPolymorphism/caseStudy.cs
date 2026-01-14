using System;
using System.Collections.Generic;
using System.Text;
namespace CaseStudy13
{
	public abstract class Dimension_Shape
	{
		protected string colorValue;
		public Dimension_Shape(string color)
		{
			this.colorValue = color;
		}
		public string getColor()
		{
			return colorValue;
		}
		public abstract double getAreaOf_Shape();
	}
	public class ShapeCircle : Dimension_Shape
	{
		private double radiusOfCircle;
		public ShapeCircle(string colorValue, double radius) : base(colorValue)
		{
			this.radiusOfCircle = radius;
		}
		public override double getAreaOf_Shape()
		{
			return Math.PI * radiusOfCircle * radiusOfCircle;
		}
	}
	public class ShapeRectangle : Dimension_Shape
	{
		private double lengthOfRectangle;
		private double widthOfRectangle;
		public ShapeRectangle(string colorValue, double length, double width) : base(colorValue)
		{
			this.lengthOfRectangle = length;
			this.widthOfRectangle = width;
		}
		public override double getAreaOf_Shape()
		{
			return lengthOfRectangle * widthOfRectangle;
		}
	}
	public class ShapeSquare : Dimension_Shape
	{
		private double lengthOfSquare;
		public ShapeSquare(string colorValue, double length) : base(colorValue)
		{
			this.lengthOfSquare = length;
		}
		public override double getAreaOf_Shape()
		{
			return lengthOfSquare * lengthOfSquare;
		}
	}
	class AreaAndColor
	{
		static void Main(string[] args)
		{
			Console.WriteLine("This is an example where all the properties of different classes\nlike Circle, Square can be defined in another class and can be inherited \nfrom it when required without populating the classes with excess codes.");
			Console.WriteLine("--------------------");
			Dimension_Shape myCircle = new ShapeCircle("Maroon", 6);
			Dimension_Shape myRectangle = new ShapeRectangle("Blue", 12, 9);
			Dimension_Shape mySquare = new ShapeSquare("Gray", 15);
			Console.WriteLine("The Circle is of " + myCircle.getColor() + " color and its area is " + myCircle.getAreaOf_Shape() + ".");
			Console.WriteLine("--------------------");
			Console.WriteLine("The Rectangle is of " + myRectangle.getColor() + " color and its area is " + myRectangle.getAreaOf_Shape() + ".");
			Console.WriteLine("--------------------");
			Console.WriteLine("The Square is of " + mySquare.getColor() + " color and its area is " + mySquare.getAreaOf_Shape() + ".");
			Console.WriteLine("--------------------");
		}
	}
}