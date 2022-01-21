using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus7
{
    class Hissi
    {
        private readonly int MaxKerros = 6;
        private int kerros { get; set; }
        public int Kerros
        {
            get { return kerros; }
            set 
            {
                if (value> MaxKerros)
                {
                    value = MaxKerros;
                }
                kerros = value;
            }
        }
        public void AsetaKerros()
        {
            Kerros= Convert.ToInt32(Console.ReadLine()); //Tämä vaihtaa annetun arvon Console.Readline() komennosta Int muotoon jotta loput koodista pystytään suorittamaan
            Console.WriteLine("Olet kerroksessa: " + Kerros.ToString());          
        }

    }
}
