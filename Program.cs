﻿// File name: Program.cs
// Project Name: Manipulating-Arrays
// Author: Orndoff, Robert K.
// Date created: 07/17/2019
// Date last modified: 07/17/2019
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

            ////Counting, summing, computing the mean
            //Console.WriteLine($"The average of Array A is:{CountSumAverage(arrayA)}");
            //Console.WriteLine($"\nThe average of Array B is:{CountSumAverage(arrayB)}");
            //Console.WriteLine($"\nThe average of Array C is:{CountSumAverage(arrayC)}");

            ////Reversing Arrays
            //PrintCollection(ReverseArray(arrayA));
            //PrintCollection(ReverseArray(arrayB));
            //PrintCollection(ReverseArray(arrayC));

            ////Rotating arrays
            string direction = "L";
            int places = 2;
            PrintCollection(RotateArray(direction, places, arrayA));

            direction = "R";
            PrintCollection(RotateArray(direction, places, arrayB));

            direction = "L";
            places = 4;
            PrintCollection(RotateArray(direction, places, arrayC));

            ////Sorting arrays (It's Pi!)
            //SortArray(arrayC);
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


        static T[] ReverseArray<T>(T[] array)
        {
            int v = 0;
            T[] new_Array = new T[array.Length];
            for(int i = array.Length - 1; i >= 0; i--)
            {
                new_Array[v] = array[i];
                ++v;
            }
            Console.WriteLine("\nThe reverse of the array is:");
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
                Console.WriteLine($"\nShifted {places} places to the {direction}, the array now looks like this:");
            }
            else
            {
                int counter = places -1;
                for (int i = array.Length - 1; i >= 0; --i)
                {
                    if (i > places)
                    {
                        tempArray[counter] = array[i];
                        counter--;
                    }
                    else if (i <= array.Length)
                    {
                        tempArray[i+places] = array[i];
                    }

                }
                Console.WriteLine($"\nShifted {places} places to the {direction}, the array now looks like this:");
            }
            return tempArray;
        }


        static void SortArray(int[] array)
        {

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
