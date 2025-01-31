using System;

class maxOf3{
	static int [] user(){
		Console.WriteLine("Enter first number");
		int input1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number");
		int input2 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter third number");
		int input3 = Convert.ToInt32(Console.ReadLine());
		
		int [] arr = new int [3];
		arr[0] = input1;
		arr[1] = input2;
		arr[2] = input3;
		return arr;
	}
	
	static int max(int [] arr){
		if(arr[0] > arr[1] && arr[0] > arr[2]){
			return arr[0];
		}
		else if(arr[1] > arr[0] && arr[1] > arr[2]){
			return arr[1];
		}
		else{
			return arr[2];
		}
	}
	
	public static void Main(String [] args){
		int [] arr = user();
		int result = max(arr);
		Console.WriteLine("The greatest number is "+result);
	}
}