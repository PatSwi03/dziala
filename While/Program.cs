using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj cyfry które będą podstawione za a,b i c do  ax^2 + bx + c = 0:");

        Console.Write("a: ");
        double a = antylitera();
        Console.Write("b: ");
        double b = antylitera();
        Console.Write("c: ");
        double c = antylitera();



        double delta = b * b - 4 * a * c;



        if (delta < 0)
        {
            Console.WriteLine("delta jest mniejsza od 0");
        }
        else
        {
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-b - sqrtDelta) / (2 * a);
            double x2 = (-b + sqrtDelta) / (2 * a);

            Console.WriteLine($"Pierwiastki równania kwadratowego: x1 = {x1:F2}, x2 = {x2:F2}"); // :F2 ogranicza do 2 miejsc po przecinku
        }
    }

    static double antylitera() //Odpowiada za poprawność podawanych cyfr, gdy użytkownik poda litere otrzyma komunikat "Podano literę, podaj liczbę!"
    {
        double value;
        while (!double.TryParse(Console.ReadLine(), out value))
        {
            Console.WriteLine("Podano literę, podaj liczbę!");
        }
        return value;
    }
}