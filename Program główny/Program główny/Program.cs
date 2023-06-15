using Program_główny;
using System;

Równanie_kwadratowe qe = new Równanie_kwadratowe();

Console.WriteLine("Obliczanie miejsc zerowych");
Console.WriteLine("Wzór: ax^2 + bx + c = 0\n");
Console.WriteLine("Podaj \"a\":");
qe.a = int.Parse(Console.ReadLine());

while (qe.a == 0)
{
    Console.WriteLine("Współczynnik \"a\" nie może być równy 0");
    Console.WriteLine("Podaj wartość \"a\" ponownie:");
    qe.a = int.Parse(Console.ReadLine());
}
Console.WriteLine("Podaj \"b\":");
qe.b = int.Parse(Console.ReadLine());
Console.WriteLine("Podaj \"c\":");
qe.c = int.Parse(Console.ReadLine());

Console.WriteLine("\n");
qe.calcDeltaZeros(qe.a, qe.b, qe.c);
