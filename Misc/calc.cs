using System;

class calc{
	static double add(double first, double second){
		double ad = first + second;
		return ad;
	}
	
	static double subtract(double first, double second){
		double sub = first - second;
		return sub;
	}
	
	static double product(double first, double second){
		double prod = first * second;
		return prod;
	}
	
	static double divide(double first, double second){
		double div = first / second;
		return div;
	}
		
	public static void Main(String [] args){
		Console.WriteLine("Enter a an operation (+,-,*,/)");
		string op = Console.ReadLine();
		Console.WriteLine("Enter first number");
		double first = Convert.ToDouble(Console.ReadLine());
		Console.WriteLine("Enter second number");
		double second = Convert.ToDouble(Console.ReadLine());
		
		if(op == "+"){
			double result = add(first,second);
			Console.WriteLine("The addition is "+result);
		}
		else if(op == "-"){
			double result = subtract(first,second);
			Console.WriteLine("The difference is "+result);
		}
		else if(op == "*"){
			double result = product(first,second);
			Console.WriteLine("The product is "+result);
		}
		else if(op == "/"){
			double result = divide(first,second);
			Console.WriteLine("The quotient is "+result);
		}
	}
}