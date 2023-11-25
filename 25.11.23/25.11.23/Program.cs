namespace nowy
{
    internal class Program
    {
        static int zmienna1 = 1;
        static byte zmienna2 = 2;
        static double zmienna3 = 124124124.14;
        static string zmiennax = "";

        static void Main(string[] args)
        {
            //zmienna1 = zmienna2;
            procedure2();
        }

        static void procedure2()
        {
            // zmienna2 = (byte)zmienna3;
            // zmiennax=zmienna3.ToString();
            zmienna2 = Convert.ToByte(zmienna3);
        }
    }
}