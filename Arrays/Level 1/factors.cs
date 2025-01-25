using System;

class factors{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		int length = 0 ;
		int [] factors = new int [input];
		for(int i=1; i<=input;i++){
			if(input % i == 0){
				factors[length] = i;
				length++;
			}
		}
		for(int j = 0;j<length;j++){
			Console.WriteLine(factors[j]+"\n");
		}
	}
}