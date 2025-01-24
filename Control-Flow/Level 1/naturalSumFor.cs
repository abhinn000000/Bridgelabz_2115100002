using System;

class naturalSumFor {
	public static void Main(String [] args){
		int sum = 0;
        int sum1 = 0;

        Console.WriteLine("Enter a number:");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input > 0) { 
            for (int i = 1;i <= input;i++) {
                sum += i;
            }
            sum1 = (input * (input + 1)) / 2;
            Console.WriteLine("The sum using while loop is " + sum + " and the sum using the formula is " + sum1);
        } else {
            Console.WriteLine("Not a natural number");
        }
	}
}