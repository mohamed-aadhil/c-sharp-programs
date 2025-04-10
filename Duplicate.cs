using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void FindDuplicates(List<int> list)
    {
        // Create a dictionary to store the element and its count
        Dictionary<int, int> elementCount = new Dictionary<int, int>();

        // Iterate the list and populate the dictionary with element counts
        foreach (var num in list)
        {
            if (elementCount.ContainsKey(num))
            {
                elementCount[num] += 1; 
            }
            else
            {
                elementCount[num] = 1; 
            }
        }

        // Output the duplicates
        Console.WriteLine("Duplicate elements:");
        foreach (var pair in elementCount)
        {
            if (pair.Value > 1)
            {
                Console.WriteLine($"{pair.Key}: {pair.Value} occurrences");
            }
        }
    }

    static void Main(string[] args)
    {

        try
        {
            string numbers = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(numbers))
            {
                throw new ArgumentException("Input cannot be empty or whitespace.");
            }

            List<int> list = numbers.Split(' ').Select(int.Parse).ToList();

            FindDuplicates(list);
        }

        catch (FormatException)
        {
            Console.WriteLine("Invalid input. Please enter only space-separated integers.");
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        // General Exception
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
