using System;

namespace Harjoitus10
{
    class Program
    {
        static void Main(string[] args)
        {
            Varis Varis1 = new Varis("Varis", 90);

            Varis1.MakeASound();
            Varis1.Fly();


            Kala Kala1 = new Kala("Ahven", "Blup Blup", 50);

            Kala1.MakeASound();
            Kala1.Swim();

            Sorsa Sorsa1 = new Sorsa("Sorsa", 120, 30);

            Sorsa1.MakeASound();
            Sorsa1.Swim();
            Sorsa1.Fly();

        }
    }
}
