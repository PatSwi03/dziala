using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Podaj swoją wage ciała: ");
        double waga = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj swój wzrost w metrach np 1,90: ");
        double wzrost = Convert.ToDouble(Console.ReadLine());

        double bmi = ObliczBMI(waga, wzrost);
        Console.WriteLine("Oto twoje BMI: " + bmi);

        static double ObliczBMI(double waga, double wzrost)
        {
            double bmi = waga / (wzrost * wzrost);  // [kg]/wzrost^2 [m]
            return bmi;
        }
    }
}