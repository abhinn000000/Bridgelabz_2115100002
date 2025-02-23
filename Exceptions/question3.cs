using System;
using System.IO;

class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message) { }
}

class AgeValidator
{
    public void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new InvalidAgeException("Age must be 18 or above");
        }
        Console.WriteLine("Access granted!");
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            AgeValidator validator = new AgeValidator();
            validator.ValidateAge(age);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid age.");
        }
    }
}