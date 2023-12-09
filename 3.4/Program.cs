using System;

class Program
{
    static void Main()
    {
        string[] pets = {"cat", "dog", "parrot", "guinea pig"};

        foreach (string pet in pets)
        {
            if (pet == "dog")
            {
                Console.WriteLine("End");
                break;
            }
            Console.WriteLine(pet);
        }
        Console.ReadKey();
    }
}
