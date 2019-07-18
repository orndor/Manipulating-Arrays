// File name: Program.cs
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

            //Counting, summing, computing the mean
            Console.WriteLine($"The average of Array A is:{CountSumAverage(arrayA)}");
            Console.WriteLine($"The average of Array B is:{CountSumAverage(arrayB)}");
            Console.WriteLine($"The average of Array C is:{CountSumAverage(arrayC)}");

            //Reversing arrays
            ReverseArray(arrayA);
            ReverseArray(arrayB);
            ReverseArray(arrayC);

            ////Rotating arrays
            //string direction = "L";
            //int places = 2;
            //RotateArray(direction, places, arrayA);

            //direction = "R";
            //RotateArray(direction, places, arrayB);

            //direction = "L";
            //places = 4;
            //RotateArray(direction, places, arrayC);

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
        static void ReverseArray(int[] array)
        {
            int v = 0;
            int[] new_Array = new int[array.Length];
            for(int i = array.Length-1; i >= 0; i--)
            {
                new_Array[v] = array[i];
                ++v;
            }
        }
        static void RotateArray(string direction, int places, int[] array)
        {

        }
        static void SortArray(int[] array)
        {

        }
    }
}
