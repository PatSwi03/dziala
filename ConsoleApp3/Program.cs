namespace lekcja3
    {
        internal class Program
{
    private static void Main(string[] args)
    {
            int a = 10;

            Console.WriteLine(a);
            if (a > 0 && a > 7)
            {
                Console.WriteLine("A jest większa od 0");
                Console.WriteLine("A jest większa od 7");
            }
            else if (a == 0) 
            {
                Console.WriteLine("A jest równe 0");
            }
            else
            {
                Console.WriteLine("A jest mniejsze od 0");
            }
            Console.ReadKey();

    }
  }
}