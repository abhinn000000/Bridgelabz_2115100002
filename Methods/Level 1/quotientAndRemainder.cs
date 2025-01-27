using System;

class quotientAndReamainder{
	static int[] div(int number, int divisor){
	int [] arr = new int[2];
	int remainder = number % divisor;
	int quotient = number / divisor;
	arr[0] = quotient;
	arr[1] = remainder;
	return arr;
	}

	public static void Main(String [] args){
		Console.WriteLine("Enter number");
		int input = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter divisor");
		int divisor = Convert.ToInt32(Console.ReadLine());
		
		int [] result = div(input,divisor);
		
		Console.WriteLine("The quotient is "+ result[0]);
		Console.WriteLine("The remainder is "+ result[1]);
	}
}