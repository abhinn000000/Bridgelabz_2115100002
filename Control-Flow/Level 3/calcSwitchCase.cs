using System;

class calcSwitchCase
{
    static void Main(string[] args)
    {	
		Console.WriteLine("Enter the number of times you want to run the calculator: ");
        double number = Convert.ToInt32(Console.ReadLine());
		
		for(int i=0;i<number;i++){
			
        Console.WriteLine("Enter the first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();
		
		
        switch (op)
        {
            case "+":
				double add = first + second;
                Console.WriteLine("Result "+add);
                break;

            case "-":
				double sub = first - second;
                Console.WriteLine("Result "+ sub);
                break;

            case "*":
				double product = first * second;
                Console.WriteLine("Result "+ product);
                break;

            case "/":
                if (second != 0)
                {
					double div = first / second;
                    Console.WriteLine("Result "+ div);
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;

            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
	}
    }
}
