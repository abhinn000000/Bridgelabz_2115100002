using System;

class naturalNumberMethod{
	static int natural(){
		Console.WriteLine("Enter a number");
		int num = Convert.ToInt32(Console.ReadLine());
		if(num > 0){
			int sum = num * (num+1)/2;
			return sum;
		}
		else{
			return -1;
		}
	}
	
	public static void Main(String [] args){
		Console.WriteLine(natural());
	}
}