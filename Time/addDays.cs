using System;

class addDays{
	public static void Main(String [] args){
		Console.WriteLine("Enter the date (dd/mm/yyyy)");
		DateTime input = Convert.ToDateTime(Console.ReadLine());
		DateTime adding =input.AddDays(7);
		DateTime monthAdd= adding.AddMonths(1);
		DateTime addYear = monthAdd.AddYears(2);
		DateTime subtractWeek = addYear.AddDays(-21);
		Console.WriteLine(subtractWeek);
	}
}