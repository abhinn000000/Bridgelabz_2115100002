using System;

class zeroSum {
	public static void Main(String [] args){
	int flag = 1;
	double sum = 0;
	while(flag == 1){
		Console.WriteLine("Enter a number");
		double input = Convert.ToDouble(Console.ReadLine());
		if(input == 0){
			flag = 0;
		}
		else{
			sum +=input;
		}
		}
		Console.WriteLine("The sum of the numbers entered before 0 are "+sum);
	}
}