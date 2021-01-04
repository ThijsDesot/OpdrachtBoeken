using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtBoeken
{
    public class Genre
    {
        public string Naam { get; set; }
        public Doelgroep DGroep { get; set; }

        public Genre(string naam, int leeftijd)
        {
            Naam = naam;
            DGroep = new Doelgroep(leeftijd);
        }
       
        public class Doelgroep
        {
            public int Leeftijd { get; set; }

            public string Categorie => Leeftijd < 18 ? "jeugd" : "volwassen";

            public Doelgroep(int leeftijd)
            {
                Leeftijd = leeftijd;
            }
            public override string ToString()
            {
                return $"{Leeftijd} ({Categorie})";
            }

        }
        public override string ToString()
        {
            return $"{Naam}, {DGroep}";
        }
    }
}
