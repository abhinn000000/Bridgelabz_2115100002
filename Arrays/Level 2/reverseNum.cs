using System;

class reverseNum{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		int [] arr = new int [10];
		int index = 0;
		while(input > 0){
			int digit = input % 10;
			input /= 10;
			arr[index] = digit;
			index++;
		}
		Console.WriteLine("The digits of the number in the reverse order are ");
		for(int i = 0;i < index;i++){
			Console.WriteLine(arr[i]);
		}
	}
}