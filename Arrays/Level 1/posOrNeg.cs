using System;

class posOrNeg{
	public static void Main(String [] args){
		int [] nums = new int[5];
		for(int i =0 ;i <5;i++){
		Console.WriteLine("Enter a number");
		int input = Convert.ToInt32(Console.ReadLine());
		nums[i] = input;
		}
		
		for(int j = 0;j<5;j++){
			if(nums[j] > 0){
				if(nums[j] % 2 == 0){
					Console.WriteLine("The number "+nums[j]+" is positive and even");
				}
				else{
					Console.WriteLine("The number "+nums[j]+" is positive and odd");
				}
			}
			else if(nums[j] < 0){
				Console.WriteLine("The number "+nums[j]+" is negative");
			}
			else{
				Console.WriteLine("The number "+nums[j]+" is zero");
			}
		}
		if(nums[0] > nums[4]){
				Console.WriteLine("The first element is greater than the last element");
			}
			else if(nums[0] < nums[4]){
				Console.WriteLine("The first element is lesser than the last element");
			}
			else{
				Console.WriteLine("The first and the last element are equal");
			}
	}
}