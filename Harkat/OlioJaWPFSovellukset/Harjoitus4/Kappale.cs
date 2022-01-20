using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus4
{
    class Kappale
    {
        public string Nimi { get; set; }
        public string Kesto { get; set; }

        public Kappale(string _nimi, string _kesto)
        {
            Nimi = _nimi;
            Kesto = _kesto;
        }

        public void TulostaKappale()
        {
            Console.WriteLine("-- Nimi:  " + Nimi);
            Console.WriteLine("-- Kesto:  " + Kesto);
        }

        public string ToString()
        {
            string merkkijono = ("----Nimi:  " + Nimi + " - " + Kesto);

            return merkkijono;
        }
    }
}
