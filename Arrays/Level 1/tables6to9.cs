using System;

class tables6to9{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		int [] multiplicationResult = new int [10];
		if( input > 5 && input < 10){
		for(int i = 0;i < 10;i++){
			multiplicationResult[i] = input * (i+1);
		}
		for(int j = 0;j<10;j++){
			Console.WriteLine(input +" * "+(j+1)+" = "+multiplicationResult[j]);
		}
		}
		else{
			Console.WriteLine("Not in range");
		}
	}
}