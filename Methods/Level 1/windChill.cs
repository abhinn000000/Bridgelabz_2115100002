using System;

class windChill{
	static double calculateWindChill(double temperature, double windSpeed){
		double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * windSpeed * 0.16;
		return windChill;
	}

	public static void Main(String [] args){
		Console.WriteLine("Enter the temperature");
		double temp = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter the wind speed");
		double windSpeed = Convert.ToDouble(Console.ReadLine());
		
		double result = calculateWindChill(temp, windSpeed);
		
		Console.WriteLine("The wind chill temperature "+ result);
	}
}