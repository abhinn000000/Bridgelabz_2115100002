using System;

class arrayTable{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		int [] table = new int [10];
		for(int i=0;i<10;i++){
			table[i] = (i+1) * input; 
		}
		for(int j = 0;j<10;j++){
			Console.WriteLine(input+" * "+(j+1)+" = "+table[j]);
		}
	}
}