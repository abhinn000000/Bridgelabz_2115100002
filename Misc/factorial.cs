using System;

class factorial{
	static int input(){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		return input;
	}
	
	static int fact(int input){
		if( input == 1 ){
			return 1;
		}
		else{
			return input * fact(input -1);
		}
	}
	static void display(int ans){
		Console.WriteLine("The factorial is "+ans);
	}
	
	public static void Main(String [] args){
		int input1 = input();
		int result = fact(input1);
		display(result);
	}
}