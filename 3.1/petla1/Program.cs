using System;

class Program
{
    static void Main()
    {
       for (int x = 0; x <= 10; x++)
       {
           double y = Math.Pow(3, 2) * Math.Sqrt(x);
           Console.WriteLine("Dla x wartość wynosi = " + x +", dla y wartość wynosi ="+y);
       }
       Console.ReadKey();
    }
}