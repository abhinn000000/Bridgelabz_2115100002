using System;

class UnitConvertor2{
	public static double ConvertYardsToFeet(double yards){
		double feet =  3 * yards;
		return feet;
	}
	
	public static double ConvertFeetToYards(double feet){
		double yards =  0.333333 * feet;
		return yards;
	}
	
	public static double ConvertMetersToInches(double meters){
		double inches =  39.3701 * meters;
		return inches;
	}
	
	public static double ConvertInchesToMeters(double inches){
		double meters =  0.0254 * inches;
		return meters;
	}
	
	public static double ConvertInchesToCm(double inches){
		double cm =  2.54 * inches;
		return cm;
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter a value");
		double input = Convert.ToDouble(Console.ReadLine());
		
		double yardsToFeet = ConvertYardsToFeet(input);
		double feetToYards = ConvertFeetToYards(input);
		double metersToInches = ConvertMetersToInches(input);
		double inchesToMeters = ConvertInchesToMeters(input);
		double inchesToCm = ConvertInchesToCm(input);
		
		Console.WriteLine("The conversion from yards to feet is "+yardsToFeet);
		Console.WriteLine("The conversion from feet to yards is "+feetToYards);
		Console.WriteLine("The conversion from meters to inches is "+metersToInches);
		Console.WriteLine("The conversion from inches to meters is "+inchesToMeters);
		Console.WriteLine("The conversion from inches to cm is "+inchesToCm);
	}
}