using System;

class zeroOrnot{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int num = Convert.ToInt32(Console.ReadLine());
		if(num == 0){
			Console.WriteLine("zero");
		}
		else if(num < 0){
			Console.WriteLine("negative");
		}
		else{
			Console.WriteLine("positive");
		}
	}
}