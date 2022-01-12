using System;

namespace Harjoitus2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Luodaan Opiskelija Olio
            Opiskelija Opiskelija1 = new Opiskelija("Pelle", "TVT123", 10);

            Opiskelija1.TulostaData();
            Opiskelija1.MuokkaaOpintopisteitä(5);
            Opiskelija1.TulostaData();
        }
    }
}
