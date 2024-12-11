using System;

class Program
{
    static void Main()
    {
        int input;

        do
        {
            Console.Write("Skriv in ett heltal (0 för att avsluta): ");
            input = int.Parse(Console.ReadLine());
        } while (input != 0);

        Console.WriteLine("Programmet avslutas.");

        Console.ReadKey();
    }
}
