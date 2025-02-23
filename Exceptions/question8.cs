using System;

class ExceptionPropagation
{
    public void Method1()
    {
        throw new ArithmeticException("Division by zero occurred.");
    }

    public void Method2()
    {
        Method1();
    }
}

class program8
{
    static void Main()
    {
        try
        {
            ExceptionPropagation obj = new ExceptionPropagation();
            obj.Method2();
        }
        catch (ArithmeticException)
        {
            Console.WriteLine("Handled exception in Main");
        }
    }
}
