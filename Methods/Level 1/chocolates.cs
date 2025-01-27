using System;

class chocolates{
	static int[] chocolate(int chocolates, int children){
		int [] arr = new int[2];
		int equal = chocolates/children;
		int remaining = chocolates%children;
		
		arr[0] = equal;
		arr[1] = remaining;
		
		return arr;
		
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter number of children");
		int numberOfChildren = Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Enter number of chocolates");
		int numberOfChocolates = Convert.ToInt32(Console.ReadLine());
		
		int [] result = chocolate(numberOfChocolates, numberOfChildren);
		Console.WriteLine("The number of chocolates each child gets is "+result[0]+" and the number of remaining chocolates is "+result[1]);
		
	}
}