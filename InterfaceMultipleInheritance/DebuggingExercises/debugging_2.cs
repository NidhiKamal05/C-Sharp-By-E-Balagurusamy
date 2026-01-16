using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp2_chap14
{
	interface Dimensions
	{
		float Length();
		float Width();
	}
	interface MetricDimensions
	{
		float Length();
		float Width();
	}
	class Box : Dimensions, MetricDimensions
	{
		float lengthInches;
		float widthInches;
		public Box(float length, float width)
		{
			lengthInches = length;
			widthInches = width;
		}
		// Explicitly implement the members of IEnglishDimensions:
		float Dimensions.Length()
		{
			return lengthInches;
		}
		float Dimensions.Width()
		{
			return widthInches;
		}
		float MetricDimensions.Length()
		{
			return lengthInches * 2.54f;
		}
		float MetricDimensions.Width()
		{
			return widthInches * 2.54f;
		}
		static void Main()
		{
			Box box1 = new Box(30.0f, 20.0f);
			// Declare an instance of the English units interface
			Dimensions eDimensions = (Dimensions)box1;
			MetricDimensions mDim = (MetricDimensions)box1;
			// Print dimensions in English units:
			System.Console.WriteLine("Length(in): {0}", eDimensions.Length());
			System.Console.WriteLine("Length(in): {0}", eDimensions.Width());
			// Print dimensions in metric units:
			System.Console.WriteLine("Length(cm): {0}", mDim.Length());
			System.Console.WriteLine("Length(cm): {0}", mDim.Width());
		}
	}
}



/*using System;
using System.Collections.Generic;
using System.Text;
namespace debugApp2_chap14
{
	interface Dimensions
	{
		float Length();
		float Width();
	}
	interface MetricDimensions
	{
		int Length();
		int Width();
	}
	class Box : Dimensions, MetricDimensions
	{
		float lengthInches;
		float widthInches;
		public Box(float length, float width)
		{
			lengthInches = length;
			widthInches = width;
		}
		// Explicitly implement the members of IEnglishDimensions:
		float Dimensions.Length()
		{
			return lengthInches;
		}
		float Dimensions.Width()
		{
			return widthInches;
		}
		float MetricDimensions.Length()
		{
			return lengthInches * 2.54f;
		}
		float MetricDimensions.Width()
		{
			return widthInches * 2.54f;
		}
		static void Main()
		{
			Box box1 = new Box(30.0f, 20.0f);
			// Declare an instance of the English units interface
			Dimensions eDimensions = (Dimensions)box1;
			MetricDimensions mDim = (MetricDimensions)box1;
			// Print dimensions in English units:
			System.Console.WriteLine("Length(in): {0}", eDimensions.Length());
			System.Console.WriteLine("Length(in): {0}", eDimensions.Width());
			// Print dimensions in metric units:
			System.Console.WriteLine("Length(cm): {0}", mDim.Length());
			System.Console.WriteLine("Length(cm): {0}", mDim.Width());
		}
	}
}*/