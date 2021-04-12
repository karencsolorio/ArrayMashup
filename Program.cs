using System;
using System.ComponentModel.DataAnnotations;

namespace Array_Mashup
{
    class Program
    {
        static void Main(string[] args)
        {
            int spaceCount1 = 0, spaceCount2 = 0;

            spaceCount1 = PromptInt($"How big should the 1st array be? \t ");
            if(spaceCount1 < 0)
            {
                while(spaceCount1 < 1)
                {
                    spaceCount1 = PromptInt($"You must have at least 1 spot. Enter in a positive number that is higher than 0.");
                }
            }

            spaceCount2 = PromptInt($"How big should the 2nd array be? \t ");
            if (spaceCount2 < 0)
            {
                while (spaceCount2 < 1)
                {
                    spaceCount2 = PromptInt($"You must have at least 1 spot. Enter in a positive number that is higher than 0.");
                }
            }

            int[] array1 = new int [spaceCount1];
            int[] array2 = new int [spaceCount2];
            int[] array3 = new int[spaceCount1 + spaceCount2];


            FillArray(array1, array2, spaceCount1, spaceCount2);
           CombineArray(array1, array2, spaceCount1, spaceCount2, array3);
            PrintArray(array3, spaceCount1, spaceCount2);
        }
        static int PromptInt(string text)
        {
            Console.Write(text + " ");
            return int.Parse(Console.ReadLine());
        }
        static void FillArray(int[] arrayOne, int[] arrayTwo, int spaceCount1, int spaceCount2)
        {
            int spacenumber = 0; //Number counter of each space

            Console.WriteLine("\nFill the first array");
            for(spacenumber = 0; spacenumber < spaceCount1; spacenumber++)
            {
                arrayOne[spacenumber] = PromptInt($"Array entry {spacenumber + 1} = \t ");
            }

            Console.WriteLine("\nFill the second array");
            for(spacenumber = 0; spacenumber < spaceCount2; spacenumber++)
            {
                arrayTwo[spacenumber] = PromptInt($"Array entry {spacenumber + 1} = \t ");
            }
        }
        static void CombineArray(int[] array1, int[] array2, int array1Space, int array2Space, int[] array3)
        {
            //Stores the list of array 1's # first
            for (int number = 0; number < array1Space; number++)
            {
                array3[number] = array1[number];
            }

            //Stores the list of array 2's # second
            for (int number = 0; number < array2Space; number++)
            {
                //Will put the values in array 2 after the spaces from array 1 are in.
                array3[number + array1Space] = array2[number];
            }

        }
        static void PrintArray(int[] combinedArray, int arraySpace1, int arraySpace2)
        {
            Console.Write("\n The combined array is: [");
            for(int number = 0; number < (arraySpace1 + arraySpace2); number++)
            {
                Console.Write($"{combinedArray[number]},");
            }
            Console.Write("]");
        }
    }
}
