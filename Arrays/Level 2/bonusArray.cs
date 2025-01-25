using System;

class bonusArray{
	public static void Main(String [] args){
		double [] oldSalary = new double [10];
		double [] newSalary = new double [10];
		int [] service = new int [10];
		double [] bonus = new double[10];
		
		double totalOldSalary = 0;
		double totalNewSalary = 0;
		double totalBonus = 0;
		
		for(int i = 0;i < 10;i++){
		//taking input in oldSalary
			Console.WriteLine("Enter salary");
			double input = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter years of service");
			int serv = Convert.ToInt32(Console.ReadLine());
			if(input < 0 || serv < 0){
				Console.WriteLine("Not valid");
				i--;
			}
			else{
				oldSalary[i] = input;
				service[i] = serv;
			}
			totalOldSalary += oldSalary[i];
		}
		// adding to newSalary and bonus
		for(int j = 0;j < 10;j++){
			if(service[j] > 5){
				bonus[j] = oldSalary[j] * 0.05;
			}
			else if(service[j] < 5){
				bonus[j] = oldSalary[j] * 0.02;
			}
			else{
				bonus[j] = 0;
			}
			newSalary[j] = oldSalary[j] + bonus[j];
			totalNewSalary += newSalary[j];
			totalBonus += bonus[j];
		}
		//printing the totals
			Console.WriteLine("Total old salary"+totalOldSalary);
			Console.WriteLine("Total bonus"+totalBonus);
			Console.WriteLine("Total new salary"+totalNewSalary);
	}
}