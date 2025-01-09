using Dicegame;
using System;

internal class Program
{
    private static void Main()
    {
        
        int rolls;

        Console.WriteLine("How many times do you want to roll?");
        rolls = int.Parse(Console.ReadLine());

     
        DiceFunctions df = new DiceFunctions(rolls);


        Array NumArray = df.Simulate();


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



        Dictionary<int, int> sortedCounts = counts.OrderBy(keyvalues => keyvalues.Key)
            .ToDictionary(keyvalues => keyvalues.Key, keyvalues => keyvalues.Value);

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