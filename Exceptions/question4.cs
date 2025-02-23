using System;
using System.IO;

class ArrayOperations
{
    public void RetrieveValue(int[] array, int index)
    {
        try
        {
            if (array == null)
            {
                throw new NullReferenceException("Array is not initialized!");
            }

            Console.WriteLine($"Value at index {index}: {array[index]}");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

class program4
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                Console.Write($"Enter element {i}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter index to retrieve value: ");
            int index = Convert.ToInt32(Console.ReadLine());

            ArrayOperations operations = new ArrayOperations();
            operations.RetrieveValue(array, index);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter a valid number.");
        }
    }
}
