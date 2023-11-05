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
            anonim.id = int.Parse(Console.ReadLine());
            anonim.imie = "Adam";
            anonim.nazwisko = "Kowalski";
            anonim.wiek = 26;
            anonim.plec = true;
            anonim.poziom = false;
            anonim.ranking = 3;
            
        }
    }
}