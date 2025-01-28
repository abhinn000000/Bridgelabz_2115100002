using System;
class StudentVoteChecker{
	public static bool CanStudentVote(int age){
		if( age < 18){
			return false;
		}
		else{
			return true;
		}
	}
	
	public static void Main(String [] args){
		int [] ages = new int [10];
		for(int i = 0;i < 10;i++ ){
			Console.WriteLine("Enter the age");
			int age = Convert.ToInt32(Console.ReadLine());
			ages[i] = age;
		}
		
		for(int i = 0;i < 10;i++){
			bool result = CanStudentVote(ages[i]);
			Console.WriteLine(result);
		}
		
	}
}