/*class TrigMaths
{
	public void TrigFunctions(double angle, out double sin, out double cos, out double tan)
	{
		sin = System.Math.Sin(angle);
		cos = System.Math.Cos(angle);
		tan = System.Math.Tan(angle);
	}
}
public class OutParamExample
{
	public static void Main()
	{
		double angle;
		double sin;
		double cos;
		double tan;
		TrigMaths trig = new TrigMaths();
		trig.TrigFunctions(angle, out sin, out cos, out tan);		
		System.Console.WriteLine("Sine of the angle is: " + sin);
		System.Console.WriteLine("Cosine of the angle is: " + cos);
		System.Console.WriteLine("Tangent of the angle is: " + tan);
	}
}*/

class TrigMaths
{
	public void TrigFunctions(double angle, out double sin, out double cos, out double tan)
	{
		sin = System.Math.Sin(angle);
		cos = System.Math.Cos(angle);
		tan = System.Math.Tan(angle);
	}
}
public class OutParamExample
{
	public static void Main()
	{
		double angle = 180 ;
		double sin;
		double cos;
		double tan;
		TrigMaths trig = new TrigMaths();
		trig.TrigFunctions(angle, out sin, out cos, out tan);		
		System.Console.WriteLine("Sine of the angle is: " + sin);
		System.Console.WriteLine("Cosine of the angle is: " + cos);
		System.Console.WriteLine("Tangent of the angle is: " + tan);
	}
}