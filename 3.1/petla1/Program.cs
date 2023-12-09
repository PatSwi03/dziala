using System;

class Program
{
    static void Main()
    {
       for (int x = 0; x < 11; x++)
       {
           double y = Math.Sqrt ((Math.Pow(3, 2))) * x;
           Console.WriteLine("Dla x wartość wynosi = " + x +", dla y wartość wynosi = "+y);
       }
       Console.ReadKey();
    }
}