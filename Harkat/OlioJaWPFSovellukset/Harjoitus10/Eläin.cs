using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    abstract class Eläin
    {
        public string Nimi { get; set; }

        public abstract void MakeASound();
    }
}
