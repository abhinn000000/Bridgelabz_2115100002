using System;

class factFor{
	public static void Main(String [] args){
		int fact = 1;
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		for(int i = input;i > 0;i--){
			fact *= i;
		}
		Console.WriteLine("The factorial of "+ input + " is "+fact);
	}
}