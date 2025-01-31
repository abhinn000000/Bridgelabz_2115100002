using System;

class timeFormat{
	public static void Main(String [] args){
		Console.WriteLine("Enter the date (dd/mm/yyyy)");
		DateTime input = Convert.ToDateTime(Console.ReadLine());
		Console.WriteLine(input.ToString("dd/mm/yyyy"));
		Console.WriteLine(input.ToString("yyyy-MM-dd"));
		Console.WriteLine(input.ToString("MMM dd,yyyy"));
	}
}