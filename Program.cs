using Dicegame;
using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    private static void Main()
    {
        //define the rolls variable and get rolls 
        int rolls;

        Console.WriteLine("How many times do you want to roll?");
        rolls = int.Parse(Console.ReadLine());

        //get the dicefunctions class
        DiceFunctions df = new DiceFunctions(rolls);

        //get the array from the simulate method
        Array NumArray = df.Simulate();

        //make a dictionary and add values to each value
        Dictionary<int, int> counts = new Dictionary<int, int>();

        foreach (int i in NumArray)
        {
            if (counts.ContainsKey(i))
            {
                counts[i]++;
            }

            else
            {
                counts[i] = 1;
            }
        }

       
        //sort the dictionary
        Dictionary<int, int> sortedCounts = counts.OrderBy(keyvalues => keyvalues.Key)
            .ToDictionary(keyvalues => keyvalues.Key, keyvalues => keyvalues.Value);


        //write the histogram 
        System.Console.WriteLine("Data");

        foreach (var keyValuePair in sortedCounts)
        {
            double pctn = ((double)keyValuePair.Value / rolls) * 100;

            System.Console.Write($"{keyValuePair.Key} :");
            for (int i = 0; i < Math.Round(pctn); i++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine($" {keyValuePair.Key}({keyValuePair.Value})");

        }



        System.Console.ReadLine();
    }
}