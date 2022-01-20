using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Eläin //Eläin yliluokka
    {
        private static int instanssit = 0;

        public Eläin()
        {
            instanssit++;
        }

        public static void KuinkaMonta()
        {
            Console.WriteLine("Eläimiä luotu " + instanssit);
        }
        public virtual void Ääntele() //Virtuaalinen metodi jonka voi ylikirjoitetaan aliluokissa esim.
        {
            Console.WriteLine("Eläin ääntelee");
        }
    }
}
