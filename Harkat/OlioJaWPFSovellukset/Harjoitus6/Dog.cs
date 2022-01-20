using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus6
{
    class Dog : Eläin //Koira aliluokka, perii Eläin yliluokan : Eläin toiminnolla
    {
        private static int instanssit = 0;

        public Dog()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Dogeja luotu " + instanssit);
        }
        public override void Ääntele() //ylikirjoitetaan Eläin luokan metodi
        {
            Console.WriteLine("Woof");
        }
    }
}
