using System;

class ArrayDivision
{
    public void PerformOperation(int[] array, int index, int divisor)
    {
        try
        {
            try
            {
                int value = array[index];
                int result = value / divisor;
                Console.WriteLine("Result: " + result);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Invalid array index!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
    }
}

class program9
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

            Console.Write("Enter index to access: ");
            int index = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter divisor: ");
            int divisor = Convert.ToInt32(Console.ReadLine());

            ArrayDivision operation = new ArrayDivision();
            operation.PerformOperation(array, index, divisor);
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
        }
    }
}
