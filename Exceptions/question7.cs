using System;

class DivisionProgram
{
    public void PerformDivision()
    {
        try
        {
            Console.Write("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
        finally
        {
            Console.WriteLine("Operation completed");
        }
    }
}

class program7
{
    static void Main()
    {
        DivisionProgram divisionProgram = new DivisionProgram();
        divisionProgram.PerformDivision();
    }
}
