using System;

class trigo{
	static double[] calculateTrignometricFunctions(double angle){
		double [] arr = new double [3];
		double radian = 3.14 * angle / 180;
		double sin = Math.Sin(radian);
		double cos = Math.Cos(radian);
		double tan = Math.Tan(radian);
		arr[0] = sin;
		arr[1] = cos;
		arr[2] = tan;
		return arr;
	}

	public static void Main(String [] args){
		Console.WriteLine("Enter angle in degrees");
		double angle = Convert.ToDouble(Console.ReadLine());
		
		double [] result = calculateTrignometricFunctions(angle);
		Console.WriteLine("Sin "+result[0]);
		Console.WriteLine("Cos "+result[1]);
		Console.WriteLine("Tan "+result[2]);
	}
}