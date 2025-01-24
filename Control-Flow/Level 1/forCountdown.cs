using System;

class forCountdown{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int num = Convert.ToInt32(Console.ReadLine());
		for(int i = num;i>0;i--){
			Console.WriteLine(i+"\n");
		}
		}
}