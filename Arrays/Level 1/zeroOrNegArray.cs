using System;

class zeroOrNegArray{
	public static void Main(String [] args){
		int [] nums = new int [10];
		int sum = 0;
		int count = 0;
		for(int i = 0;i<10;i++){
			Console.WriteLine("Enter a number");
			int input = Convert.ToInt32(Console.ReadLine());
			if(input <= 0){
				break;
			}
			else{
				nums[i] = input;
				sum += input;
				count++;
			}
		}
		for(int j = 0;j < count;j++){
			Console.WriteLine(nums[j]+"\n");
		}
		Console.WriteLine("The total is "+sum);
	}
}