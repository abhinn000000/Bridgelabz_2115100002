using System;

class infiniteInput {
	public static void Main(String [] args){
		double sum = 0;
		while(true){
			Console.WriteLine("Enter a number");
			double input = Convert.ToDouble(Console.ReadLine());
			if( input == 0 || input < 0){
				break;
			}
			else{
				sum += input;
			}
		}
		Console.WriteLine("The sum of numbers entered before entering a 0 or a negative number is "+sum);
	}
}