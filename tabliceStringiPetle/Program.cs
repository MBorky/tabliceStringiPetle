// See https://aka.ms/new-console-template for more information

// Readout function parameters
// Do while to protect against the entry of a zero
double a, b, c;
do
{
    a = functionDataInput('a');
    if (a == 0)
    {
        Console.WriteLine("a nie może wynosić 0, podaj wartość ponownie");
    }
} while (a == 0);
b = functionDataInput('b');
c = functionDataInput('c');
// Computing delta
double delta = computeDelta(a, b, c);
functionRoots(delta, a, b, c);

static double computeDelta(double a, double b, double c)
{
    return Math.Sqrt(b) - 4 * a * c;
}
static void functionRoots(double computedDelta, double a, double b, double c)
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
static double functionDataInput(char mark)
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
