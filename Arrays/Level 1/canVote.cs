using System;

class canVote{
	public static void Main(String [] args){
		int [] ages = new int [10];
		Console.WriteLine("Enter the ages");
		for(int i= 0;i<10;i++){
			int input = Convert.ToInt32(Console.ReadLine());
			ages[i] = input;
		}
		for(int j = 0;j<10;j++){
			if(ages[j] < 0){
				Console.WriteLine("Invalid age");
			}
			else if(ages[j] > 18){
				Console.WriteLine("The student with the age "+ages[j]+" can vote");
			}
			else{
				Console.WriteLine("The student with the age "+ages[j]+" cannot vote");
			}
		}
	}
}