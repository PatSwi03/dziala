namespace nowy
{
    internal class Program
    {
        static int zmienna1 = 2;
        static int zmienna1a = 3;
        static byte zmienna2 = 2;
        static double zmienna3 = 124124124.14;
        static string zmiennax = "";
        static DateTime zmienna4 = DateTime.Now;

        static void Main(string[] args)
        {
            //zmienna1 = zmienna2;
            procedure2();
            operatory();
        }

        static void procedure2()
        {
            // zmienna2 = (byte)zmienna3;
            // zmiennax=zmienna3.ToString();
            //zmienna2 = Convert.ToByte(zmienna3);
            //Console.WriteLine(zmienna4);
            //zmienna1 = (int)(zmienna4.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
           // Console.WriteLine(zmienna1);

           // zmienna4 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(zmienna1);
           // Console.WriteLine(zmienna4.ToLocalTime());
           // float a = 222.3F;
           // Console.WriteLine(a);
            // string s1 = "1. Dodaj zawodnika\n2. Usuń zawodnika\n3. Zamknij program";
            //string s1 = "myszka \r Mickey \r";
            //string s1 = "myszka \t Mickey \t";
            //string s1 = "myszka \t \v Mickey";
            //string s1 = "\a myszka Mickey - dźwięki windows";
            //string s1 = "' myszka Mickey";
           // Console.WriteLine(zmienna3 + 3);
        }

        static void operatory(bool wynik)
        {
            //float wynik = zmienna1 / (float)zmienna1a;
            //var wynik = zmienna1 % zmienna1a;
            //zmienna1++;
            //zmienna1++;
            // zmienna1--;




            /* if ((zmienna1 != zmienna1a) || (zmienna1==3))
             {
                 zmienna1 = 12;
             }*/





            /*if (!(zmienna1 != zmienna1a) && (zmienna1 == 3))
            {
                zmienna1 = 12;
            }*/




            //zmienna1 = zmienna1 + 5;
            //zmienna1 += 5;
            //zmienna1 *= 5;


            Console.WriteLine(sizeof(decimal));
            Console.ReadKey();
            //float do tego by liczby wyszły inne, przypisać to do zmiennej1 w tymp przypadku.




            //Console.WriteLine(zmienna1==zmienna1a);
            // Console.WriteLine(zmienna1);
            // Console.ReadKey();
            //Console.WriteLine(zmienna1);
            Console.ReadKey();


            /*unsafe
            {
                int* pointer = &CharEnumerator;
                long adres = (long)pointer;
                Console.WriteLine($"Adres pamięci mojej zmiennej numer: 0x{adres:X}");
            }
            */

            zmienna1 = -5;

            wynik = zmienna1 > 0 ? "Pozytywnie" : zmienna1 < 0 ? "Nie za bardzo" : "zero";
            int a = zmienna1 > 0 ? zmienna1 : -100;
            Console.WriteLine(wynik is int);
            
            Console.ReadKey();

        }

        
        
    }
}