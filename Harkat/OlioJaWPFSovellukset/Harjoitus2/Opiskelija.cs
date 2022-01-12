using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus2
{
    class Opiskelija
    {
        private string Nimi { get; set; }
        private string OpiskelijaID { get; set; }
        private int OpintoPisteet { get; set; }


        //Konstruktori
        public Opiskelija(string _nimi, string _id, int _op)
        {
            Nimi = _nimi;
            OpiskelijaID = _id;
            OpintoPisteet = _op;
        }

        public void TulostaData()
        {
            Console.WriteLine();
            Console.WriteLine("Opiskelija: ");
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- OpiskelijaID:  " + OpiskelijaID);
            Console.WriteLine("-- OpintoPisteet:  " + OpintoPisteet);
            Console.WriteLine();
        }

        //Metodi joka ottaa parametriksi integer - arvon
        public void MuokkaaOpintopisteitä(int i)
        {
            OpintoPisteet = OpintoPisteet +i;
            if (OpintoPisteet < 0)
            {
                OpintoPisteet = 0;
            }
        }
    }
}
