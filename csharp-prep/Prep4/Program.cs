using System;

class Program
{
    static void Main(string[] args)
    {   Console.WriteLine("Enter a list of numbers, type 0 when finished");
        List<int> number = new List<int>();
        
        int endNumber = -1;
        
        while (endNumber != 0)
        {   // ask the user for a number
            Console.Write("enter a number: ");
            string addNumber = Console.ReadLine();
            endNumber = int.Parse(addNumber);

            if (endNumber != 0)
            {   number.Add(endNumber);}
        }
        // get the sum of the list
        int sum = 0;
        foreach (int numbers in number)
        {   sum += numbers;}

        Console.WriteLine($"The sum is {sum}");
        // get the average

        float average = (float)sum / number.Count;
        Console.WriteLine($"The average is {average}.");

        int max = number[0];
        foreach (int numbers in number)
        if (numbers > max)
        {  max = numbers;}
        Console.WriteLine($"The max number is {max}.");

        }

    }