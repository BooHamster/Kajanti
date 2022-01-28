using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus13
{
    class Pelaaja
    {
        private string Etunimi { get; set; }
        private string Sukunimi { get; set; }
        private int PelaajaNumero { get; set; }

        public Pelaaja(string _etu, string _suku, int _numero)
        {
            Etunimi = _etu;
            Sukunimi = _suku;
            PelaajaNumero = _numero;
        }

        public string HaeData() //Opiskelijan tietojen tulostamiseen tarkoitettu Metodi
        {
            return Etunimi + " " + Sukunimi + "." + " Pelaaja Numero: " + PelaajaNumero + "."; //Palauttaa nämä tiedot, tämän voisi kyllä toteuttaa myös Console.Write komennolla myös
        }

    }
}
