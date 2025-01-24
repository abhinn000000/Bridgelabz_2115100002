using System;

class divisibilityBy5{
	public static void Main(String [] args){
		Console.WriteLine("Enter the number");
		int num = Convert.ToInt32(Console.ReadLine());
		if(num % 5 != 0){
			Console.WriteLine("Is the number "+num+" divisible by 5? No");
		}
		else{
			Console.WriteLine("Is the number "+num+" divisible by 5? Yes");
		}
	}
}