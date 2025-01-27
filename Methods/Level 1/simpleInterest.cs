using System;

class simpleInterest{
	static void simpleInt(){
		Console.WriteLine("Enter rate");
		double rate = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter time");
		double time = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter pinciple");
		double principle = Convert.ToDouble(Console.ReadLine());
		double si = time * rate * principle/100;
		Console.WriteLine("The Simple Interest is "+si+" for Principle "+principle+" , rate "+rate +" and time "+time);
	}
	
	public static void Main(String [] args){
		simpleInt();
	}
}