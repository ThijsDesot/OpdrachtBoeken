using System;

namespace OpdrachtBoeken
{
    class Program
    {
        static void Main(string[] args)
        {
            Boek boekske = new Boek();
            Console.WriteLine(boekske.Eigenaar);
        }
    }
}
