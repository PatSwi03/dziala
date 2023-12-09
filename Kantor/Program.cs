using System;

internal class Program
{
    const double PLNdoUSD = 0.25;
    const double USDdoEUR = 0.91;
    const double USDdoCHF = 0.88;
    const double USDdoGBP = 0.79;

     static void Main()
    {
        Console.WriteLine("Podaj kwotę w PLN: ");
        double zloty = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj walutę na którą chcesz przeliczyć złotówki (Dopuszczalne: USD, EUR, CHF, GBP)");
        string przeliczeniawaluty = Console.ReadLine().ToUpper();

        double wynik = Przeliczanienawalute(zloty, przeliczeniawaluty);

        Console.WriteLine("Przewalutowanie wynosi: " + wynik + przeliczeniawaluty);
    }

     static double Przeliczanienawalute(double zloty, string przeliczeniawaluty)
    {
        double PLNnaUSD = zloty * PLNdoUSD;

        switch (przeliczeniawaluty)
        {
            case "USD":
                return PLNnaUSD;
            case "EUR":
                return PLNnaUSD * USDdoEUR;
            case "CHF":
                return PLNnaUSD * USDdoCHF;
            case "GBP":
                return PLNnaUSD * USDdoGBP;
            default:
                throw new ArgumentException("Podano nieprawidłową walutę!");
        }
    }
}