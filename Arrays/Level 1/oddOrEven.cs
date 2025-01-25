using System;

class oddOrEven{
	public static void Main(String [] args){
		Console.WriteLine("Enter length");
		int length = Convert.ToInt32(Console.ReadLine());
		int [] even = new int [(length+1)/2];
		int [] odd = new int [(length+1)/2];
		int evenCount=0;
		int oddCount=0;
		for(int i = 1;i <= length;i++){
				if( i % 2 == 0){
					even[evenCount] = i;
					evenCount++;
				}
				else{
					odd[oddCount] = i;
					oddCount++;
				}
		}
		Console.WriteLine("Even array");
		for(int j = 0;j < evenCount;j++){
			Console.WriteLine(even[j]+"\n");
		}
		Console.WriteLine("Odd array");
		for(int j = 0;j < oddCount;j++){
			Console.WriteLine(odd[j]+"\n");
		}
	}
}