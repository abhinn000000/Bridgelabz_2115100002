using System;

class tables{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		
		if( input > 5 && input < 10){
			Console.WriteLine("The table of "+input+" is\n");
			for(int i=1;i<=10;i++){
				Console.WriteLine(input+" * "+ i +" = "+ i*input+"\n");
			}
		}
	}
}