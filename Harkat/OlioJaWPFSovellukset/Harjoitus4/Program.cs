using System;

namespace Harjoitus4
{
    class Program
    {
        static void Main(string[] args)
        {
            Albumi GreatestHitsEltonJohn = new Albumi();
            GreatestHitsEltonJohn.Artisti = "Elton John";
            GreatestHitsEltonJohn.Nimi = "Greatest Hits";
            GreatestHitsEltonJohn.Genre = "Pop";
            GreatestHitsEltonJohn.Hinta = "50 £";
            GreatestHitsEltonJohn.LisääKappale();            
            GreatestHitsEltonJohn.TulostaData();
        }
    }
}
