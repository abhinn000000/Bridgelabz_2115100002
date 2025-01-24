using System;

class evenOdd{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		if( input > 0 ){
			int i = 1;
			while( i <= input ){
				if(i % 2 == 0){
					Console.WriteLine(i+" Even\n");
					i++;
				}
				else{
					Console.WriteLine(i+" Odd\n");
					i++;
				}
			}
		}
		else{
			Console.WriteLine("Not a natural number");
		}
	}
}