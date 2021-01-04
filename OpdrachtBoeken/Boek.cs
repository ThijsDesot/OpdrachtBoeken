using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtBoeken
{
    public abstract class Boek : IVoorwerpen
    {
        public  Boek(string titel, string auteur, decimal aankoopprijs, Genre genre)
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


        public virtual void Print()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Titel: {Titel}");
            Console.WriteLine($"Auteur: {Auteur}");
            Console.WriteLine($"Eigenaar: {Eigenaar}");
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Aankoopprijs: {Aankoopprijs} EUR");
            Console.WriteLine($"Winst: {Winst} EUR");
            
            
        }
    }
}
