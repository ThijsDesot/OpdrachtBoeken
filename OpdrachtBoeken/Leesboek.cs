using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtBoeken
{
    public class Leesboek : Boek
    {
        public string Onderwerp { get; set; }
        public override decimal Winst => Aankoopprijs * 1.5m;


        public Leesboek(string titel, string auteur, decimal aankoopprijs, Genre genre, string onderwerp) : base(titel, auteur, aankoopprijs, genre)
        {
            Onderwerp = onderwerp;
        }
    }
}
