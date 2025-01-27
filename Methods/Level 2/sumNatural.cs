using System;

class sumNatural{
		static int recursion(int num){
		if(num <= 1){
			return num;
			}
		else{
			return num + recursion(num-1);
		}
		}
		
		static int sum(int num){
			int total = 0;
			total = num * (num + 1)/2;
			return total;
		}

	public static void Main(String [] args){
		Console.WriteLine("Enter a natural number");
		int input = Convert.ToInt32(Console.ReadLine());
		
		if( input > 0){
			int recur = recursion(input); 
			int total = sum(input);
			Console.WriteLine("The ans using recursion is "+recur);
			Console.WriteLine("The ans using the formula is "+total);
		}
		else{
			Environment.Exit(0);
		}
	}
}