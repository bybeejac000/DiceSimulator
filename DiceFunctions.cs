using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Dicegame
{
    internal class DiceFunctions
    {
        int rolls;
        public DiceFunctions(int temp)
        {
            rolls = temp;
        }

        public void Simulate()
        {
            Random random = new Random();
            int firstDie;
            int secondDie;
            int[] NumArray = new int[rolls];

            for (int i = 0; i < rolls; i++)
            {
                firstDie = random.Next(1,7);
                secondDie = random.Next(1,7);

                int sumResult = firstDie + secondDie;

                NumArray[i] = sumResult;
            }

            Dictionary<int, int> counts = new Dictionary<int, int>();

            foreach(int i in NumArray)
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

            foreach(var keyValuePair in sortedCounts)
            {
                double pctn = ((double)keyValuePair.Value / rolls)*100;

                System.Console.Write($"{keyValuePair.Key} :");
                for (int i = 0; i < Math.Round(pctn); i++)
                {
                    System.Console.Write("*");
                }

                System.Console.WriteLine($" {keyValuePair.Key}({keyValuePair.Value})");
            }
            
        }
    }
}
