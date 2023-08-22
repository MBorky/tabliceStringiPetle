using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
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
        for (int i = 0; i < arr.Length; i++)
        {
            tempArr[arr.Length - i - 1] = arr[i];
        }
        return tempArr;
    }
    static bool IsPalindrome(string word)
    {
        // validation
        if (string.IsNullOrEmpty(word))
        {
            Console.WriteLine("Podano pusty string lub null");
            return false;
        }
        int wordLength = word.Length;
        string tempWord = word.ToLower();
        // Check if there is any character that is not a letter (according to the ASCII table)
        for (int i = 0; i < wordLength; i++)
        {
            if  ((int)tempWord[i] < 97 || (int)tempWord[i] > 122) // za pomocą char.IsLetter pewnie lepiej, uznałem że poćwiczę casting i ascii table
            {

                Console.WriteLine("To nie jest słowo ");
                return false;
            }
            // Check if it is a palindrome, I know I could split it into 2 loops for readability
            if (i < wordLength / 2)
            {
                // comparing one half of a word with another half
                if (tempWord[i] != tempWord[wordLength - i - 1])
                {

                    Console.WriteLine("Nie jest palindromem ");
                    return false;
                }
            }
        }    
        Console.WriteLine("Jest palindromem");
        return true;
    }
    static int SumNumbersToN(int n)
    {
        int sum = 0;
        for (int i = 0; i <= n; i++)
        {
            sum += i;
        }
        return sum;
    }
    static int Factorial(int n)
    {
        int result = 1;
        for(int i = 1;i <= n;i++)
        {
            result *= i;
        }
        return result;
    }
    static string PasswordGenerator()
    {
        string input;
        int passLength;
        bool properNumber;
        // Protection against bad input - I know it should be in a separeted function
            do
            {
                Console.WriteLine("Podaj długośc hasła: ");
                input = Console.ReadLine();
                properNumber = int.TryParse(input, out passLength);
                if (!properNumber)
                    Console.WriteLine("niepoprawny format liczby, podaj ponownie");
            } while (!properNumber || passLength == 0);
        // Generating password
        Random rnd = new Random();
        char[] password = new char[passLength];
        int asciiRange;
        // First step: Determine the ASCII range to use (for each character)
        // Second step: Select the specific character to add to the password
        for (int i = 0; i < passLength; i++)
        {
            asciiRange = rnd.Next(3);
            if (asciiRange == 0)
            {
            // Number
                password[i] = (char)rnd.Next(48, 58);
            }
            // Capital letter
            else if (asciiRange == 1) 
            {
                password[i] = (char)rnd.Next(65, 91);
            }
            // Lowercase
            else
            {
                password[i] = (char)rnd.Next(97, 123);
            }
           
        }
        string passwordToReturn = new string(password);
        return passwordToReturn;
    }
    static int LinearSearch(int[] arr, int toFind)
    {
        int arrLength = arr.Length;
        for(int i = 0; i < arrLength; i++)
        {
            if (arr[i] == toFind)
            {
                return i;
            } 
  
        }
        return -1;
    }
    static int BinarySearch(int[] arr,int toFind)
    {
        int left = 0;
        int right = arr.Length - 1;
        // Non stop same dilemma - should I initializing out of iteration or not?
        int mid = 0; 
        while(left <= right)
        {
            mid = (left + right) / 2;
            if (arr[mid] == toFind)
            {
                return mid;
            }
            else if (toFind < arr[mid])
            {
                right = mid - 1;
            }
            else if (toFind > arr[mid])
            {
                left = mid + 1;
            }
        }
        return -1;
    }

}
