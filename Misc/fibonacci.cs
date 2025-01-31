using System;

class fibonacci{
	static int fibo(int pos){
	int a =0;
	int b =1;
	int c = 0;
	if(pos == 1){
		return 1;
	}
	else if(pos == 2){
		return 1;
	}else{
		int i =2;
		while(i < pos ){
			 c = a + b;
			 a = b;
			 b = c;
			 i++;
		}
		return c;
	}
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter position");
		int input = Convert.ToInt32(Console.ReadLine());
		int result = fibo(input);
		Console.WriteLine(result);
	}
}