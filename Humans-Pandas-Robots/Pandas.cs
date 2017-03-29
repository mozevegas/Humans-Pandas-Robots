﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans_Pandas_Robots
{
    class Pandas : Creatures, IEat
    {
        public Pandas() : base("name")
        {
        }

        public string Food { get; set; }

        public void GoToSleep ()
        {
            Console.WriteLine("The Panda is Asleep. zzzzzzzzzzz");
        }

        public void Eat()
        {
            Console.WriteLine($"It appears the panda eats {Food}.");
        }
    }
}
