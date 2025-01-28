using System;

class UnitConvertor3{
	public static double ConvertFarhenheitToCelcius(double far){
		double celcius =   (far - 32) * 5 / 9 ;
		return celcius;
	}
	
	public static double ConvertCelciusToFarhenheit(double celcius){
		double far =  (celcius * 9 / 5) + 32; 
		return far;
	}
	
	public static double ConvertPoundsToKg(double pounds){
		double kg =   0.453592 * pounds;
		return kg;
	}
	
	public static double ConvertKgToPounds(double kg){
		double pounds =  2.20462 * kg;
		return pounds; 
	}
	
	public static double ConvertGallonsToLiters(double gallons){
		double liters =  3.78541 * gallons;
		return liters;
	}
	
	public static double ConvertLitersToGallons(double liters){
		double gallons =  0.264172 * liters;
		return gallons;
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter a value");
		double input = Convert.ToDouble(Console.ReadLine());
		
		double farhenheitToCelcius = ConvertFarhenheitToCelcius(input);
		double celciusToFarhenheit = ConvertCelciusToFarhenheit(input);
		double poundsToKg = ConvertPoundsToKg(input);
		double KgToPounds = ConvertKgToPounds(input);
		double gallonsToLiters = ConvertGallonsToLiters(input);
		double litersToGallons = ConvertLitersToGallons(input);
		
		Console.WriteLine("The conversion from farhenheit to celcius is "+farhenheitToCelcius);
		Console.WriteLine("The conversion from celcius to farhenheit is "+celciusToFarhenheit);
		Console.WriteLine("The conversion from pounds to kg is "+poundsToKg);
		Console.WriteLine("The conversion from kg to pounds is "+KgToPounds);
		Console.WriteLine("The conversion from gallons to liters is "+gallonsToLiters);
		Console.WriteLine("The conversion from liters to gallons is "+litersToGallons);
	}
}