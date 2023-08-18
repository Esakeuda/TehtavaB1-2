using System;

namespace TehtäväB1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pyydetään käyttäjältä x ja y arvot
            Console.Write("Syötä x-arvo: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Syötä y-arvo: ");
            int y = int.Parse(Console.ReadLine());

            // Lasketaan x = y + 3
            x = y + 3;

            // Tulostetaan tulos
            Console.WriteLine("x = " + x);
        }
    }
}
