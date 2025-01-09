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

        public Array Simulate()
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

            return NumArray;

           
        }
    }
}
