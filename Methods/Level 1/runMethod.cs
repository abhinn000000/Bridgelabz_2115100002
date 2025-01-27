using System;

class runMethod{
	static void run(){
		Console.WriteLine("Enter length of side 1");
		double side1 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter length of side 2");
		double side2 = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter length of side 3");
		double side3 = Convert.ToDouble(Console.ReadLine());
		
		double peri = side1 + side2 + side3;
		double rounds = 5 / peri;
		Console.WriteLine("The number of rounds to complete 5 kms is "+ rounds);
	}

	public static void Main(String [] args){
		run();
	}
}