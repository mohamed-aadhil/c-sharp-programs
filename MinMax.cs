using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
public class MinMax
{

    public class MinMaxResult
    {
		public int Min;
		public int Max;

        public MinMaxResult(int min, int max)
        {
            Min = min;
            Max = max;
        }
    }
    //Function to find MinMax Value 
    static void FindMinMax(List<int> list, out MinMaxResult result)

    {
		int max = int.MinValue;
		int min = int.MaxValue;

		list.ForEach(num =>
		{
			max = num > max ? num : max; //max value
			min = num < min ? num : min; //min value
		});

        result = new MinMaxResult(min, max);
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

            MinMaxResult result;

            FindMinMax(list, out result);

            Console.WriteLine($"Min: {result.Min}, Max: {result.Max}");
        }

        catch (FormatException)
        {
			Console.WriteLine("Invalid input. Please enter only integers.");
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.InnerException);
        }

		// General Exception
        catch (Exception e)
		{ 
			Console.WriteLine(e.Message);
		}
	}	
}
