using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus5
{
    class Laskin
    {
        public int ValueA { get; set; }
        public int ValueB { get; set; }
        public int Summa1;
        public int Erotus1;
        public int KertoLasku1;
        public int JakoLasku1;


        public void Summa()
        {
            Summa1 = ValueA + ValueB;
            Console.WriteLine("Tulokseksi tuli {0}", Summa1);
        }

        public void Erotus()
        {
            Erotus1 = ValueA - ValueB;
            Console.WriteLine("Tulokseksi tuli {0}", Erotus1);
        }
        public void KertoLasku()
        {
            KertoLasku1 = ValueA * ValueB;
            Console.WriteLine("Tulokseksi tuli {0}", KertoLasku1);
        }

        public void JakoLasku()
        {
            JakoLasku1 = ValueA / ValueB;
            Console.WriteLine("Tulokseksi tuli {0}", JakoLasku1);
        }

    }
}
