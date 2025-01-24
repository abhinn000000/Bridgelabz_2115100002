using System;

class whileCountdown{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int num = Convert.ToInt32(Console.ReadLine());
		while(num != 0){
			Console.WriteLine(num+"\n");
			num--;
		}
	}
}