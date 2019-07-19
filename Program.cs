// File name: Program.cs
// Project Name: Manipulating-Arrays
// Author: Orndoff, Robert K.
// Date created: 07/17/2019
// Date last modified: 07/19/2019
//
// C#
using System;

namespace Manipulating_Arrays
{
    class Program
    {
        static void Main()
        {
            int[] arrayA = new int[6] { 0, 2, 4, 6, 8, 10 };
            int[] arrayB = new int[5] { 1, 3, 5, 7, 9 };
            int[] arrayC = new int[12] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };

            //Counting, summing, computing the mean
            Console.WriteLine($"\nThe average of array A is:{CountSumAverage(arrayA)}");
            Console.WriteLine($"\nThe average of array B is:{CountSumAverage(arrayB)}");
            Console.WriteLine($"\nThe average of array C is:{CountSumAverage(arrayC)}");

            //Reversing Arrays
            Console.WriteLine("\nThe reverse of array A is:");
            PrintCollection(ReverseArray(arrayA));
            Console.WriteLine("\nThe reverse of array B is:");
            PrintCollection(ReverseArray(arrayB));
            Console.WriteLine("\nThe reverse of array C is:");
            PrintCollection(ReverseArray(arrayC));

            //Rotating arrays
            string direction = "L";
            int places = 2;
            Console.WriteLine($"\nShifted {places} places to the {direction}, array A now looks like this:");
            PrintCollection(RotateArray(direction, places, arrayA));

            direction = "R";
            Console.WriteLine($"\nShifted {places} places to the {direction}, array B now looks like this:");
            PrintCollection(RotateArray(direction, places, arrayB));

            direction = "L";
            places = 4;
            Console.WriteLine($"\nShifted {places} places to the {direction}, array C now looks like this:");
            PrintCollection(RotateArray(direction, places, arrayC));

            //Sorting arrays (It's Pi!)
            Console.WriteLine($"\nThe first 12 digits of Pi sorted is:");
            PrintCollection(SortArray(arrayC));
        }


        static double CountSumAverage(int[] array)
        {
            double sum = 0;
            foreach(int v in array)
            {
                sum += v;
            }
            double average = sum / array.Length;
            return average; 
        }


        static int[] ReverseArray(int[] array)
        {
            int v = 0;
            int[] new_Array = new int[array.Length];
            for(int i = array.Length - 1; i >= 0; i--)
            {
                new_Array[v] = array[i];
                ++v;
            }
            
            return new_Array;
        }


        static int[] RotateArray(string direction, int places, int[] array)
        {
            int[] tempArray = new int[array.Length];
            if (direction == "L")
            {
                for (int i = 0; i <= array.Length - 1; ++i)
                {
                    if(i < places)
                    {
                        tempArray[(array.Length) - places + i] = array[i];
                    }
                    else if(i <= array.Length)
                    {
                        tempArray[i-places] = array[i];
                    }
                }
            }
            else
            {
                for (int i = array.Length - 1; i >= 0; --i)
                {
                    if (i > places)
                    {
                        tempArray[i - 1 - places] = array[i];
                    }
                    else if (i <= array.Length)
                    {
                        tempArray[i+places] = array[i];
                    }
                }
            }

            return tempArray;
        }


        static int[] SortArray(int[] array)
        {
            bool test = true;
            int bucket = 0;
            for(int i = 1; (i <= array.Length) && test; i++)
            {
                test = false;
                for (int j = 0; j < (array.Length - 1); j++)
                {
                    if (array[j + 1] > array[j])
                    {
                        bucket = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = bucket;
                        test = true;
                    }
                }
            }

            return array;
        }


        static void PrintCollection<T>(T[] toPrint, bool oneIndexed = false)
        {
            string PrintWithIndex(int index) => $"{index + (oneIndexed ? 1 : 0)}: {toPrint[index]}, ";
            int i = 0;
            Console.Write("{ ");
            for (; i < toPrint.Length - 1; ++i)
            {
                Console.Write($"{PrintWithIndex(i)} ");
            }
            Console.WriteLine($"{i + (oneIndexed ? 1 : 0)}: {toPrint[i]} }}");
        }
    }
}
