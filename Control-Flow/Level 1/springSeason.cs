using System;

class springSeason{
	public static void Main(String [] args){
		Console.WriteLine("Enter the date");
		int date = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the month");
		int month = Convert.ToInt32(Console.ReadLine());
		
		if(month == 3){
			if(date >= 20 && date <= 31){
				Console.WriteLine("It's a spring season");
			}
			else{
				Console.WriteLine("Not a spring season");
			}
		}
			else if(month == 6){
				if(date < 21){
					Console.WriteLine("It's a spring season");
				}
				else{
					Console.WriteLine("Not a spring season");
				}
			}
			else if(month > 3 && month < 6){
				Console.WriteLine("It's a spring season");
			}
			else{
				Console.WriteLine("Not a spring season");
			}
		
	}
}