using System;

class checkPrime{
	static bool prime(int input){
		bool isPrime = true;
		for(int i = 2;i < input/2;i++){
			if(input % i == 0){
				isPrime = false;
			}
		}
		if(isPrime == false){
			return false;
		}
		else{
			return true;
		}
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		bool result = prime(input);
		Console.WriteLine(result);
	}
}