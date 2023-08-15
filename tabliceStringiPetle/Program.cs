// See https://aka.ms/new-console-template for more information

// Podanie danych  i sprawdzenie danych
// Aktualnie żałuję, że nie zrobiłem tego na tablicy[], bo wyszło dużo powtarzalnego kodu.
using System.ComponentModel.Design;

double a, b, c;
string temporaryNumber;
bool properNumber;

do
{
    Console.WriteLine("Podaj a:");
    temporaryNumber = Console.ReadLine();
    properNumber = double.TryParse(temporaryNumber, out a);
    if (!properNumber)
        Console.WriteLine("niepoprawny format liczby, podaj ponownie");
    if (a == 0)
    {
        properNumber = false;
        Console.WriteLine("a nie może = 0! Podaj liczbę ponownie");
    }
}  while (!properNumber);

do
{
    Console.WriteLine("Podaj b:");
    temporaryNumber = Console.ReadLine();
    properNumber = double.TryParse(temporaryNumber, out b);
    if (!properNumber)
        Console.WriteLine("niepoprawny format liczby, podaj ponownie");
} while (!properNumber);

do
{
    Console.WriteLine("Podaj c:");
    temporaryNumber = Console.ReadLine();
    properNumber = double.TryParse(temporaryNumber, out c);
    if (!properNumber)
        Console.WriteLine("niepoprawny format liczby, podaj ponownie");
} while (!properNumber);

// Obliczenie delta
double delta = Math.Sqrt(b) - 4 * a * c;
Console.WriteLine("delta wynosi {0}", delta);

// Wiem, że mogłem to zrobić bez deklarowania zmiennych, ale pomyślałem, że ze zmiennymi
// bardziej perspektywicznie x).
double xOne, xTwo, xZero;
// Delta > 0;
if (delta > 0)
{
    xOne = (-b - Math.Sqrt(delta)) / (2 * a);
    xTwo = (-b + Math.Sqrt(delta)) / (2 * a);
    // String Formating dla wprawy
    Console.WriteLine("Delta wynosi: {0}\nx1 wynosi: {1}\nx2 wynosi: {2}", delta, xOne, xTwo);
}
// Delta = 0
else if (delta == 0)
{
    // String Interpolation dla wprawy 
    xZero = -b / (2 * a);
    Console.WriteLine("Delta Wynosi: {delta}\nx0 wynosi: {xZero}");
}
// Delta < 0
else if (delta < 0);
{
    Console.WriteLine("Brak pierwiastków");
}
