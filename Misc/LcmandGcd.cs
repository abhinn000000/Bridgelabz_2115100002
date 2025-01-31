using System;

class LcmandGcd{
	static int lcm(int first,int second){
		int ans = 1;
		int greater = Math.Max(first,second);
		for(int i = 1;i <= greater;i++){
			if((i * first) % second == 0){
				ans = i * first; 
			}
		}
		return ans;
	}
	
	static int gcd(int first,int second,int lcm){
		int gcd = first * second / lcm;
			return gcd;
	}
	
	public static void Main(String [] args){
		Console.WriteLine("Enter first number");
		int input1 = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second number");
		int input2 = Convert.ToInt32(Console.ReadLine());
		int LCM = lcm(input1,input2);
		int GCD = gcd(input1,input2,LCM);
		Console.WriteLine("LCM: "+LCM);
		Console.WriteLine("GCD: "+GCD);
	}
}