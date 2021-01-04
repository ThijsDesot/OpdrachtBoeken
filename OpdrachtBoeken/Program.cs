using System;

namespace OpdrachtBoeken
{
    class Program
    {
        static void Main(string[] args)
        {
            IVoorwerpen[] artikels = new IVoorwerpen[3];
            artikels[0] = new Leesboek("De donkere toren", "Stephen King", 30, new Genre("fictie", 18), "Fantasy");
            artikels[1] = new Woordenboek("Van Dale Woordenboek", "VBK", 140, new Genre("woordenboek", 6), "Nederlands");
            artikels[2] = new Boekenrek(4, 2, 150);
            decimal winst = 0m;
            foreach (var artikel in artikels)
            {
                artikel.Print();
                winst += artikel.Winst;
            }
            Console.WriteLine($"Totale winst: {winst} EUR");
        }
    }
}
