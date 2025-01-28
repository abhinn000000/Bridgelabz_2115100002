using System;


class FootballTeamHeights
{
    static void Main(string[] args)
    {
        // Generate random heights for the football team
        int[] heights = GenerateRandomHeights(11, 150, 250);

        Console.WriteLine("Player Heights (in cms): " + string.Join(", ", heights));

        int sumOfHeights = FindSum(heights);
        double meanHeight = FindMean(heights);
        int shortestHeight = FindShortestHeight(heights);
        int tallestHeight = FindTallestHeight(heights);

        // Display results
        Console.WriteLine("Sum of Heights: " + sumOfHeights + " cms");
        Console.WriteLine("Mean Height: " + meanHeight + " cms");
        Console.WriteLine("Shortest Height: " + shortestHeight + " cms");
        Console.WriteLine("Tallest Height: " + tallestHeight + " cms");
    }

    // Generate an array of random heights
    static int[] GenerateRandomHeights(int size, int min, int max)
    {
        Random random = new Random();
        int[] heights = new int[size];
        for (int i = 0; i < size; i++)
        {
            heights[i] = random.Next(min, max + 1);
        }
        return heights;
    }

    // Find the sum of all elements in the array
    static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int height in heights)
        {
            sum += height;
        }
        return sum;
    }

    // Find the mean height of the players
    static double FindMean(int[] heights)
    {
        return (double)FindSum(heights) / heights.Length;
    }

    // Find the shortest height
    static int FindShortestHeight(int[] heights)
    {
        int shortest = heights[0];
        foreach (int height in heights)
        {
            if (height < shortest)
            {
                shortest = height;
            }
        }
        return shortest;
    }

    // Find the tallest height
    static int FindTallestHeight(int[] heights)
    {
        int tallest = heights[0];
        foreach (int height in heights)
        {
            if (height > tallest)
            {
                tallest = height;
            }
        }
        return tallest;
    }
}
