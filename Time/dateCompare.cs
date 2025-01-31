using System;

class dateCompare{
	public static void Main(String [] args){
		Console.WriteLine("Enter a date (dd/mm/yyyy)");
		DateTime input1 = Convert.ToDateTime(Console.ReadLine());
		Console.WriteLine("Enter a date (dd/mm/yyyy)");
		DateTime input2 = Convert.ToDateTime(Console.ReadLine());
		int result = DateTime.Compare(input1,input2);
		if(result == 0){
			Console.WriteLine("The dates are the same");
		}
		else if(result < 0){
			Console.WriteLine(input1+" is earlier than "+input2);
		}
		else{
			Console.WriteLine(input2+" is earlier than "+input1);
		}
	}
}