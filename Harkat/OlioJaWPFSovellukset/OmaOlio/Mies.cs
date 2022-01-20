using System;
using System.Collections.Generic;
using System.Text;

namespace OmaOlio
{
    class Mies
    {
        public int Elämä = 100;
        public string Nimi;
        public bool Kuollut;
        public bool NimiAnnettu = false;

        public Mies(bool _elos, int _elämä)
        {
            Kuollut = _elos;
            Elämä = _elämä;
        }

        public void NäytäInfo()
        {
            if(NimiAnnettu !=true)
            {
                Nimi = Console.ReadLine();
            }
            Console.WriteLine("Elämä Pointsit: " + Elämä + " Tila: Olet vielä elossa!" + " Urpon nimi: " + Nimi);
        }

        public void OtaLämää(int i)
        {
            Elämä = Elämä - i;
        }
    }
}   
