using System;
using System.Collections.Generic;
using System.Text;

namespace Harjoitus10
{
    interface ICanSwim
    {
        public int SwimSpeed { get; set; }

        public void Swim();
 
    }
}
