using System;

class temp{
	static double farToCelcius(double far){
		double celcius = (far - 32) * 5/9;
		return celcius;
	}
	
	static double celToFar(double cel){
		double far = cel * 9/5 + 32;
		return far;
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter temp is celcius");
		double cel = Convert.ToDouble(Console.ReadLine());
		double far = celToFar(cel);
		Console.WriteLine("The temp in farhenheit is "+ far);
		
		Console.WriteLine("Enter temp is farhenheit");
		double far1 = Convert.ToDouble(Console.ReadLine());
		double cel1 = farToCelcius(far1);
		Console.WriteLine("The temp in farhenheit is "+ cel1);
	}
}