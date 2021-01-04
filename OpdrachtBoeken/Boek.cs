using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtBoeken
{
    class Boek : IVoorwerpen
    {
        public Boek(string titel, string auteur, decimal aankoopprijs, Genre genre)
        {
            Titel = titel;
            Auteur = auteur;
            Eigenaar = "VDAB";
            Aankoopprijs = aankoopprijs;
            Genre = genre;
        }
        
        public string Titel { get; set; }
                
        public string Auteur { get; set; }
                
        public string Eigenaar { get; set; }

        public decimal Aankoopprijs { get; set; }

        public Genre Genre { get; set; }

        public virtual decimal Winst => throw new NotImplementedException();
    }
}
