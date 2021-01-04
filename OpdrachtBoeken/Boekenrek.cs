using System;
using System.Collections.Generic;
using System.Text;

namespace OpdrachtBoeken
{
    public class Boekenrek : IVoorwerpen
    {
        public Boekenrek(float hoogte, float breedte, decimal aankoopprijs)
        {
            Hoogte = hoogte;
            Breedte = breedte;
            AankoopPrijs = aankoopprijs;
        }
  
        public float Hoogte { get; set; }
         
        public float Breedte { get; set; }
         
        public decimal AankoopPrijs { get; set; }

        public decimal Winst => AankoopPrijs * 2;

        

        public virtual void Print()
        {
            Console.WriteLine(" ");
            Console.WriteLine($"Hoogte: {Hoogte} meter");
            Console.WriteLine($"Breedte: {Breedte} meter");
            Console.WriteLine($"Aankoopprijs: {AankoopPrijs} EUR");
            Console.WriteLine($"Winst: {Winst} EUR");
            
        }
    }
}
