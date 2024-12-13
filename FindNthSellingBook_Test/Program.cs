using System;
using System.Collections.Generic;
using System.Linq;

public class BookSale
{
    public static int NthLowestSelling(int[] sales, int n)
    {
        // Check for invalid inputs
        if (sales == null || sales.Length == 0 || n <= 0)
            throw new InvalidOperationException("Inputs are invalid");

        // Dictionary to store the frequency of each sale count
        Dictionary<int, int> saleFrequency = new Dictionary<int, int>();

        // Count the frequency of each sale
        foreach (var sale in sales)
        {
            if (!saleFrequency.ContainsKey(sale))
            {
                saleFrequency[sale] = 1;
            }
            else
            {
                saleFrequency[sale]++;
            }
        }

        // Sort the sale counts by frequency
        var sortedSales = saleFrequency.OrderBy(x => x.Value).ThenBy(x => x.Key).ToList();

        // Find the Nth lowest selling book based on frequency
        if (sortedSales.Count >= n)
        {
            return sortedSales[n - 1].Key;
        }

        // If N is out of range, return 0
        return 0;
    }

    public static void Main(string[] args)
    {
        // Example usage
        int x = NthLowestSelling(new int[] { 11, 99, 44, 77, 99, 11, 33, 44, 77, 11, 99, 44, 11, 99, 11 }, 2);
        Console.WriteLine("Input Array : 11, 99, 44, 77, 99, 11, 33, 44, 77, 11, 99, 44, 11, 99, 11");
        Console.WriteLine("N : 2");
        Console.WriteLine("\n\nResult - "+ x);  // Output should be 44 (the second lowest selling book)
    }
}
