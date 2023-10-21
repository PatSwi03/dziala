namespace Lekcja2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int b = 9;
            int c = 2;
            //* mnożenie
            // / dzielenie
            // + dodawanie
            // - odejmowanie
            // % reszta z dzielenia

            bool a = 2 == 2;
            bool d = !(2 == 2);
            bool e = !true;
            bool g = 1 == 1 && 1 != 2;
            bool h = 1 == 1 || 1 != 2;
            int f = 2 + 2 * 3;
            bool i = 2 == 2 && 3 != 4;
            int j = 2 + 2;
            int k = 2 / 1;
            bool l = j != k;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            Console.WriteLine(f);
            Console.WriteLine(g);
            Console.WriteLine(h);
            Console.WriteLine(i);
            Console.WriteLine(l);
            Console.WriteLine(Math.Pow(5, 2));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Abs(-5));
            Console.WriteLine(Math.Abs(5));
            Console.ReadKey();
        }
    }
}