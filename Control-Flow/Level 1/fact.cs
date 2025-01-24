using System;

class fact{
	public static void Main(String [] args){
		int fact = 1;
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		int i = input;
		while(i > 0){
			fact *= i;
			i--;
		}
		Console.WriteLine("The factorial of "+ input + " is "+fact);
	}
}