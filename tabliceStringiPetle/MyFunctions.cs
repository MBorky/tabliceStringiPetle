﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    partial class Program
    {
        static double ComputeDelta(double a, double b, double c)
        {
            return Math.Sqrt(b) - 4 * a * c;
        }
        static void FunctionRoots(double computedDelta, double a, double b, double c)
        {
            double xOne, xTwo, xZero;
            // Delta > 0;
            if (computedDelta > 0)
            {
                xOne = (-b - Math.Sqrt(computedDelta)) / (2 * a);
                xTwo = (-b + Math.Sqrt(computedDelta)) / (2 * a);
                // String Formating dla wprawy
                Console.WriteLine("Delta wynosi: {0}\nx1 wynosi: {1}\nx2 wynosi: {2}", computedDelta, xOne, xTwo);
            }
            // Delta = 0
            else if (computedDelta == 0)
            {
                // String Interpolation dla wprawy 
                xZero = -b / (2 * a);
                Console.WriteLine("Delta Wynosi: {delta}\nx0 wynosi: {xZero}");
            }
            // Delta < 0
            else if (computedDelta < 0)
            {
                Console.WriteLine("Brak pierwiastków");
            }
        }
        static double FunctionDataInput(char mark)
        {
            string temporaryNumber;
            bool properNumber;
            double temporaryArg;
            do
            {
                Console.WriteLine($"Podaj {mark}:");
                temporaryNumber = Console.ReadLine();
                properNumber = double.TryParse(temporaryNumber, out temporaryArg);
                if (!properNumber)
                    Console.WriteLine("niepoprawny format liczby, podaj ponownie");
            } while (!properNumber);
            return temporaryArg;
        }
        static int BiggestElementinArr(int[] arr)
        {
        // Checking array initialization
        if (arr == null)
        {
            Console.WriteLine("Error, null value for arr");
            return 0;
        }
        // checking if an array has elements
        if (arr.Length == 0)
        {
            Console.WriteLine("Error, array length is 0!");
            return 0;
        }
        int maxValue = arr[0];
        for (int i = 1; i < arr.Length; i++)
            if (arr[i] > maxValue)
            {
                maxValue = arr[i];
            }
        return maxValue;
        }
        static int EvenNumbersSum(int[] arr)
        {
        // Checking array initialization
        if (arr == null)
        {
            Console.WriteLine("Error, null value for arr");
            return 0;
        }
        // checking if an array has elements
        if (arr.Length == 0)
        {
            Console.WriteLine("Error, array length is 0!");
            return 0;
        }
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 == 0)
            {
                sum += arr[i];
            }

        }
        return sum;
        }
        static int[] ReturnReverseArr(int[] arr)
        {
        // Checking array initialization
        if (arr == null)
        {
            Console.WriteLine("Error, null value for arr");
            return null;
        }
        // checking if an array has elements
        if (arr.Length == 0)
        {
            Console.WriteLine("Error, array length is 0!");
            return new int[0];
        }
            int[] tempArr = new int[arr.Length];
        for(int i = 0;i < arr.Length;i++) 
        {
            tempArr[arr.Length - i - 1] = arr[i];
        }
            return tempArr;
        }

    }