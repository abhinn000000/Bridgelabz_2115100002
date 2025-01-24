using System;

class Armstrong{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		int digitsCount = 0;
		int copy = input;
		int armstrong = 0;
		int digit =0;
		while(copy > 0){
			copy /= 10;
			digitsCount++;
		}
		copy = input;
		while(copy > 0){
			digit = copy%10;
			armstrong += (int)Math.Pow(digit,digitsCount);
			copy /= 10;
		}
		if(armstrong == input){
			Console.WriteLine(input +" is an Armstrong number");
		}
		else{
			Console.WriteLine(input +" is not an Armstrong number");
		}
	}
}