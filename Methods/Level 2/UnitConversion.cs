using System;

class UnitConvertor{
	public static double ConvertKmToMiles(double km){
		double miles =  0.621371 * km;
		return miles;
	}
	
	public static double ConvertMilesToKm(double miles){
		double km =  1.60934 * miles;
		return km;
	}
	
	public static double ConvertMetersToFeet(double meters){
		double feet =  3.28084 * meters;
		return feet;
	}
	
	public static double ConvertFeetToMeters(double feet){
		double meters =  0.3048 * feet;
		return meters;
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter a value");
		double input = Convert.ToDouble(Console.ReadLine());
		
		double kmToMiles = ConvertKmToMiles(input);
		double milesToKm = ConvertMilesToKm(input);
		double metersToFeet = ConvertMetersToFeet(input);
		double feetToMeters = ConvertFeetToMeters(input);
		
		Console.WriteLine("The conversion from km to miles is "+kmToMiles);
		Console.WriteLine("The conversion from miles to km is "+milesToKm);
		Console.WriteLine("The conversion from meters to feet is "+metersToFeet);
		Console.WriteLine("The conversion from feet to meters is "+feetToMeters);
	}
}