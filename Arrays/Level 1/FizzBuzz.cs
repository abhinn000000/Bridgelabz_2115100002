using System;

class FizzBuzz{
	public static void Main(String [] args){
		Console.WriteLine("Enter a number");
		int length = Convert.ToInt32(Console.ReadLine());
		string [] arr = new string [length];
		for(int i = 0;i < length;i++){
			if(i % 3 ==0 && i % 5 ==0){
				arr[i] = "FizzBuzz";
				
			}
			else if(i % 5 ==0){
				arr[i] = "Buzz";
			}
			else if( i % 3 ==0){
				arr[i] = "Fizz";
			}
			else{
				arr[i] = Convert.ToString(i);
			}
		}
		Console.WriteLine("The array is");
		for(int j =0;j < length;j++){
			Console.WriteLine(arr[j]);
		}
	}
}