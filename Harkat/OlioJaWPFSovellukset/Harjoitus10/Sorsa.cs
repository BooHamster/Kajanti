using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    class Sorsa : Eläin, ICanFly, ICanSwim
    {
        public float WingSize { get; set; }
        public int SwimSpeed { get; set; }
        public Sorsa(string _nimi, float _wingsize, int _speed)
        {
            Nimi = _nimi;
            WingSize = _wingsize;
            SwimSpeed = _speed;
        }
        public void Fly()
        {
            Console.WriteLine("{0} lentää. Siipien koko on {1}", Nimi, WingSize);
        }

        public override void MakeASound()
        {
            Console.WriteLine("Quack Quack!");
        }

        public void Swim()
        {
            Console.WriteLine("Sorsa {0}, ui nopeudella {1}", Nimi, SwimSpeed);
        }
    }
}
