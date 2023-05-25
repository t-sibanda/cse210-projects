using System;

class ListOfNumbers
{
    static void Main(string[] args)
    {
        // Create a list to store the numbers.
        List<int> numbers = new List<int>();

        // Ask the user for a series of numbers, and append each one to the list. Stop when they enter 0.
        int number;
        do
        {
            Console.WriteLine("Enter a number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        } while (number != 0);

        // Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }

        // Compute the average of the numbers in the list.
        float average = (float)sum / numbers.Count;

        // Find the maximum, or largest, number in the list.
        int max = numbers[0];
        foreach (int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }

        // Find the smallest positive number (the positive number that is closest to zero).
        int smallestPositive = numbers[0];
        foreach (int num in numbers)
        {
            if (num > 0 && num < smallestPositive)
            {
                smallestPositive = num;
            }
        }

        // Sort the numbers in the list and display the new, sorted list. Hint: There are C# libraries that can help you here, try searching the internet for them.
        List<int> sortedNumbers = numbers.OrderBy(x => x).ToList();

        // Display the results.
        Console.WriteLine("The sum is: {0}", sum);
        Console.WriteLine("The average is: {0}", average);
        Console.WriteLine("The largest number is: {0}", max);
        Console.WriteLine("The smallest positive number is: {0}", smallestPositive);
        Console.WriteLine("The sorted list is:");
        foreach (int num in sortedNumbers)
        {
            Console.WriteLine("{0}", num);
        }
    }
}