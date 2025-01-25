using System;

class meanHeight{
	public static void Main(String [] args){
		double [] heights = new double [11];
		double sum = 0;
		for(int i = 0; i < 11;i++){
			Console.WriteLine("Enter height");
			double height = Convert.ToDouble(Console.ReadLine());
			heights[i] = height;
			sum += heights[i];
		}
		Console.WriteLine("The mean height is "+sum/11);
	}
}