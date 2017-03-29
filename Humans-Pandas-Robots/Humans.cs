using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans_Pandas_Robots
{
    class Humans : Creatures, IEat
    {

        public Humans() : base("Name")
        {
        }

        public string Food { get; set; }


        public void GoToSleep()
        {
            Console.WriteLine("The Panda is Asleep. zzzzzzzzzzz");
        }

        public void WakeUp()
        {
            Console.WriteLine("The Panda is now Awake.");
        }


        public void Eat()
        {
            Console.WriteLine($"I have eaten {Food}");
        }
    }
}
