using System;

class 2dTo1d{
	public static void Main(String [] args){
		Console.WriteLine("Enter the number of rows");
		int rows = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the number of columns");
		int columns = Convert.ToInt32(Console.ReadLine());
		int [,] twoD = new int [rows , columns];
		int [] oneD = new int [rows * columns];
		
		for(int i = 0;i < rows;i++){ //inputting the values in 2d array 
			for(int j = 0;j < columns;j++){
				Console.WriteLine("Enter the element");
				int input = Convert.ToInt32(Console.ReadLine());
				twoD [i,j] = input;
			}
		}
		for(int k = 0;k < rows * columns;k++){ //Conversion from twoD to oneD array
			int i = k/columns;
			int j = k%rows;
			oneD[k] = twoD[i,j];
		}
		for(int l=0;l<rows * columns;l++){ //printing the oneD array
			Console.WriteLine(oneD[l]+"\n");
		}
	}
}