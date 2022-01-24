using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    class Kala : Eläin, ICanSwim
    {
        public int SwimSpeed { get; set; }
        public string Sound { get; set; }
        public Kala(string _nimi, string _sound, int _speed)
        {
            Nimi = _nimi;
            Sound = _sound;
            SwimSpeed = _speed;
        }
        public override void MakeASound()
        {
            Console.WriteLine("blup blup");
        }
        public void Swim()
        {
            Console.WriteLine("Kala {0}, ui nopeudella {1}", Nimi, SwimSpeed);
        }
    }
}
