// See https://aka.ms/new-console-template for more information

// Exercise 1. Calculate the roots of a quadratic function
// Readout function parameters
// Do while to protect against the entry of a zero
double a, b, c;
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

