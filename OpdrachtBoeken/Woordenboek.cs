using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtBoeken
{
    public class Woordenboek : Boek
    {
        public string Taal { get; set; }
        public override decimal Winst => Aankoopprijs * 1.75m;
        public Woordenboek(string titel, string auteur, decimal aankoopprijs, Genre genre, string taal) : base(titel, auteur, aankoopprijs, genre)
        {
            Taal = taal;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Taal: {Taal}");
        }

    }
}
