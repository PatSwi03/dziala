using System;

class Program
{
    static void Main()
    {
        double a = 3.5;
        double b = 6.0;
        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));    //a^2+b^2=c^2

        Console.WriteLine("Długość przeciwprostokątnej trójkąta prostokątnego o przyprostokątnych dla a = 'a = 3.5' i 'b = 6' wynosi: \n"+ c);
        Console.ReadKey();
    }  
}