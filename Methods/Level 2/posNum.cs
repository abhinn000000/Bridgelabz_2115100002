using System;

class posNum{
	static bool isPos(int num){
		if(num > 0 ){
			return true;
		}
		else{
			return false;
		}
	}
	
	static bool isEven(int num){
		if(num % 2 == 0){
			return true;
		}
		else{
			return false;
		}
	}
	
	static int compare(int num1, int num2){
		if(num1 > num2){
			return 1;
		}
		else if(num2 > num1){
			return -1;
		}
		else{
			return 0;
		}
	}
	
	public static void Main(String [] args){
		int [] arr = new int [5];
		for(int i = 0;i < 5;i++){
			Console.WriteLine("Enter a number");
			int input = Convert.ToInt32(Console.ReadLine());
			arr[i] = input;
		}
		for(int i =0; i < 5;i++){
		if(isPos(arr[i])){
			if(isEven(arr[i])){
				Console.WriteLine("Positive and even");
			}
			else{
				Console.WriteLine("Positive and odd");
			}
		}
		else{
			Console.WriteLine("Negative");
		}
		}
		if(compare(arr[0],arr[4]) == 1){
			Console.WriteLine("Greater");
		}
		else if(compare(arr[0],arr[4]) == -1){
			Console.WriteLine("Less");
		}
		else{
			Console.WriteLine("equal");
		}
	}
}