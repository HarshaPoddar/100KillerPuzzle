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
            int[] NewArray = new int[(TotalPeople + 1) / 2];
            int NewArrayIndex = 0;

            for (int index = 0; index < TotalPeople; index += 2)
            {

                NewArray[NewArrayIndex] = Number[index];
                NewArrayIndex++;
            }

            if (TotalPeople % 2 == 0)
                return LastManStanding(NewArray);
            else
            {
                int[] NewArray2 = new int[(TotalPeople + 1) / 2];
                for (int index = 1; index < NewArrayIndex; index++)
                {
                    NewArray2[index] = NewArray[index - 1];
                    NewArray2[0] = NewArray[index];
                }
                return LastManStanding(NewArray2);

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
