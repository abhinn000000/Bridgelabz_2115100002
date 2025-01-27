using System;

class largestSmallest{
	static int[] largeAndSmall(int number1, int number2, int number3){
		int [] arr = new int [2];
		if(number1 > number2 && number1 > number3){
			arr[1] = number1; 
		}
		else if(number2 > number1 && number2 > number3){
			arr[1] = number2;
		}
		else {
			arr[1] = number3;
		}
		
		if(number1 < number2 && number1 < number3){
			arr[0] = number1; 
		}
		else if(number2 < number1 && number2 < number3){
			arr[0] = number2;
		}
		else {
			arr[0] = number3;
		}
		
		return arr;
	}

	public static void Main(String [] args){
		Console.WriteLine("Enter first number");
		int first = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number");
		int second = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter third number");
		int third = Convert.ToInt32(Console.ReadLine());
		
		int[] result = largeAndSmall(first,second,third);
		
		Console.WriteLine("Smallest "+ result[0]);
		Console.WriteLine("Greatest "+ result[1]);
	}
}