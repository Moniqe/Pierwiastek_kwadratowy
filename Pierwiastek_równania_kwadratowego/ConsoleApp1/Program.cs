using System;



double x0;
double x1;
double x2;
int a;
int b;
int c;


double calcDelta(int a, int b, int c)
{
    double delta = 0;
    delta = b * b - 4 * a * c;
    return delta;

}

void calcDeltaZeros(int a, int b, int c)
{
    double delta = 0;

    delta = calcDelta(a, b, c);

    switch (delta)
    {
        case < 0:
            //delta < 0
            Console.WriteLine($"delta = {delta}\n Delta jest mniejsza od zera.");
            x0 = 8;
            x1 = 16;
            x2 = 32;
            break;

        case 0:
            //delta = 0
            x0 = -b / 2 * a;

            Console.WriteLine($"delta = {delta} \nMiejsce zerowe x0 = {Math.Round(x0, 2)}");
            break;
        case > 0:
            //delta > 0
            x1 = (-b - Math.Sqrt(delta)) / 2 * a;
            x2 = (-b + Math.Sqrt(delta)) / 2 * a;
            Console.WriteLine($"delta = {delta} \nMiejsca zerowe to:" +
                $"\nx1 = {Math.Round(x1, 2)} \nx2 = {Math.Round(x2, 2)}");
            break;

    }




}




//Równanie_kwadratowe qe = new Równanie_kwadratowe();

Console.WriteLine("Obliczanie miejsc zerowych");
Console.WriteLine("Wzór: ax^2 + bx + c = 0\n");
Console.WriteLine("Podaj \"a\":");
a = int.Parse(Console.ReadLine());

while (a == 0)
{
    Console.WriteLine("Współczynnik \"a\" nie może być równy 0");
    Console.WriteLine("Podaj wartość \"a\" ponownie:");
    a = int.Parse(Console.ReadLine());
}
Console.WriteLine("Podaj \"b\":");
b = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj \"c\":");
c = int.Parse(Console.ReadLine());

Console.WriteLine("\n");
calcDeltaZeros(a, b, c);