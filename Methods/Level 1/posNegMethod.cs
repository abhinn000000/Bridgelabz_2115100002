using System;

class posNegMethod{
	static int checkNum(){
		Console.WriteLine("Enter a number");
		int num = Convert.ToInt32(Console.ReadLine());
		
		if(num > 0){
			return 1;
		}
		else if(num < 0){
			return -1;
		}
		else {
			return 0;
		}
	}

	public static void Main(String [] args){
		Console.WriteLine(checkNum());
	}
}