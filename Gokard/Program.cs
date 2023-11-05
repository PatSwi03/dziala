using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gokardy
{
    class Program
    {

        public struct Zawodnik
        {
           public int id;
           public string imie;
           public string nazwisko;
           public bool plec;
           public byte wiek;
           public bool poziom;
           public int ranking;
        }
        static void Main(string[] args)
        {
            Zawodnik anonim = new Zawodnik(); 
            anonim.id = int.Parse(pobierzDane("Podaj id"));
            anonim.imie = pobierzDane("Podaj imię");
            anonim.nazwisko = pobierzDane("Podaj nazwisko");
            anonim.wiek = byte.Parse(pobierzDane("Podaj wiek"));
            anonim.plec = bool.Parse(pobierzDane("Podaj płeć"));
            anonim.poziom = bool.Parse(pobierzDane("Podaj poziom"));
            anonim.ranking = int.Parse(pobierzDane("Podaj ranking"));

        }
        static string pobierzDane(string doWyswietlenia)
        {
            Console.WriteLine(doWyswietlenia);
            return Console.ReadLine();
        }
    }
}