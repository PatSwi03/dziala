using System;

class Program
{
    static void Main()
    {
        int x = 1;
        do
        {
            int square = x * x;
            Console.WriteLine("Kwadrat liczby " + x + square);

            x++;
        } while (x <= 20);
        Console.ReadKey();
    }
}