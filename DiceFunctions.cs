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
        //define the rolls variable and get it from the class
        int rolls;
        public DiceFunctions(int temp)
        {
            rolls = temp;
        }


        //define the simulate method and return the array 
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
