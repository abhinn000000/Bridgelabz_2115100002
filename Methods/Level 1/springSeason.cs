using System;

class springSeason{
	static bool spring(){
		Console.WriteLine("Enter the date");
		int date = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the month");
		int month = Convert.ToInt32(Console.ReadLine());
		
		if(month == 3){
			if(date >= 20 && date <= 31){
				return true;
			}
			else{
				return false;
			}
		}
			else if(month == 6){
				if(date < 21){
					return true;
				}
				else{
					return false;
				}
			}
			else if(month > 3 && month < 6){
				return true;
			}
			else{
				return false;
			}
		
	}
	
	public static void Main(String [] args){
		Console.WriteLine(spring());
	}
}