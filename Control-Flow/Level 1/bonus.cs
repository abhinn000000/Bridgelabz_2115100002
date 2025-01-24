using System;

class bonus {
	public static void Main(String [] args){
		Console.WriteLine("Enter the years of service");
		int service = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the salary of the employee");
		double salary = Convert.ToDouble(Console.ReadLine());
		double bonus = 0;
		if( service > 5 ){
			bonus = salary * 0.05;
			Console.WriteLine("Your bonus is "+bonus);
		}
		else{
			Console.WriteLine("You have no bonus amount");
		}
	}
}