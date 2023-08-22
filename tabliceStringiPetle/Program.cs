// See https://aka.ms/new-console-template for more information

// Exercise 1. Calculate the roots of a quadratic function
// Readout function parameters
// Do while to protect against the entry of a zero
/*double a, b, c;
do
{
    a = FunctionDataInput('a');
    if (a == 0)
    {
        Console.WriteLine("a nie może wynosić 0, podaj wartość ponownie");
    }
} while (a == 0);
b = FunctionDataInput('b');
c = FunctionDataInput('c');
double delta = ComputeDelta(a, b, c);
FunctionRoots(delta, a, b, c);

Console.WriteLine(PasswordGenerator());
*/
int[] intArrUnsorted = { 13, 2, 65, 6, 89, 3, 0, -3, 5 };
Console.WriteLine(LinearSearch(intArrUnsorted, -3));
int[] intArrSorted = { -20, -16, -6, 0, 12, 965, 1855, 2000 };
Console.WriteLine(BinarySearch(intArrSorted, 2000));