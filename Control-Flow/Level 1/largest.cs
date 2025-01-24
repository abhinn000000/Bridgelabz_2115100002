using System;

class largest{
	public static void Main(String [] args){
		Console.WriteLine("Enter the first number");
		int num1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the second number");
		int num2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the third number");
		int num3=Convert.ToInt32(Console.ReadLine());
		
		if(num1 > num2 && num1 > num3){
			Console.WriteLine("Is the first number the larget? Yes\n"+
			"Is the second number the larget? No\n"+
			"Is the third number the larget? No");
		}
		else if(num2 > num1 && num2 > num3){
			Console.WriteLine("Is the first number the larget? No\n"+
			"Is the second number the larget? Yes\n"
			+"Is the third number the larget? No");
		}
		else{
			Console.WriteLine("Is the first number the larget? No\n"+
			"Is the second number the larget? No\n"+
			"Is the third number the larget? Yes");
		}
	}
}