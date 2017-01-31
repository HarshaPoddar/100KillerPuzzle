using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Puzzle
{
    class Survival
    {

        static int LastManStanding(int[] Number)
        {
            int TotalPeople = Number.Length;
            if (TotalPeople == 1)
                return Number[0];
            int[] NewTemporaryArray = new int[(TotalPeople + 1) / 2];
            int NewTemporaryArrayIndex = 0;

            for (int index = 0; index < TotalPeople; index += 2)
            {

                NewTemporaryArray[NewTemporaryArrayIndex] = Number[index];
                NewTemporaryArrayIndex++;
            }

            if (TotalPeople % 2 == 0)
                return LastManStanding(NewTemporaryArray);
            else
            {
                int[] NewTemporaryArray22 = new int[(TotalPeople + 1) / 2];
                for (int index = 1; index < NewTemporaryArrayIndex; index++)
                {
                    NewTemporaryArray[index] = NewArray[index - 1];
                    NewTemporaryArray[0] = NewArray[index];
                }
                return LastManStanding(NewTemporaryArray2);

            }

        }

        static void Main(string[] args)
        {

            Console.Write("Enter the number of People: ");
            int TotalNoOfPeople = Convert.ToInt16(Console.ReadLine());
            int[] People = new int[TotalNoOfPeople];

            int counter = 1;
            for (int index = 0; index < TotalNoOfPeople; index++)
            {
                People[index] = counter;
                counter++;
            }
            int Answer = LastManStanding(People);
            Console.Write("The survivor is the person No: " + Answer);
            Console.ReadLine();
        }
    }
}
