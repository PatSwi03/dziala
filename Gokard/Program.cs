using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gokardy
{
    class Program
    {
        static List<Zawodnik> zawodnicy = new List<Zawodnik>();
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
            zawodnicy.Add(pobierzZawodnika());
             
        }
        static string pobierzDane(string doWyswietlenia)
        {
            Console.Clear();
            Console.WriteLine(doWyswietlenia);
            return Console.ReadLine();
        }
        static Zawodnik pobierzZawodnika()
        {
            Zawodnik anonim = new Zawodnik();
            anonim.id = int.Parse(pobierzDane("Podaj id"));
            anonim.imie = pobierzDane("Podaj imię");
            anonim.nazwisko = pobierzDane("Podaj nazwisko");
            anonim.wiek = byte.Parse(pobierzDane("Podaj wiek"));
            string _plec = (pobierzDane("Podaj płeć K/M"));
            anonim.plec = _plec.ToUpper().StartsWith("M") ? true :
                  _plec.ToUpper().StartsWith("K") ? false : true;

            string _poziom = (pobierzDane("Podaj poziom A/Z"));
            anonim.poziom = _poziom.ToUpper().StartsWith("A") ? true :
                  _poziom.ToUpper().StartsWith("Z") ? false : true;


            anonim.ranking = int.Parse(pobierzDane("Podaj ranking 1-10000"));
            return anonim;
        }
    }
}