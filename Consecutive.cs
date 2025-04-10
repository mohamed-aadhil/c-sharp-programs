using System;
using System.Linq;
using System.Collections.Generic;

public class Consecutive
{

    //method to evaluate consecutiveness
    static bool checkConsecutive(List<int> list)
    {
        for (int i = 0; i < list.Count - 1; i++)
        {
            if(list[i+1] != list[i] + 1)
            {
                return false;
            }
        }
        return true;
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

            // sort to re-arrange the elements

            list.Sort();

            bool isConsecutive = true;

            isConsecutive = checkConsecutive(list);

            Console.WriteLine("IsConsecutive : " + isConsecutive);
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
