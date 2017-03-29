using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans_Pandas_Robots
{
    class Robots : Creatures
    {
        public Robots () : base ("name")
        {
        }

        public Robots(string type) : base(type)
        {
        }

        public void StartUp()
        {
            Console.WriteLine("The Robot has been Turned On.");
        }

        public void ShutDown()
        {
            Console.WriteLine("The Robot has been deactivated");
        }

        public void IsTerminator()
        {
            Console.WriteLine("I'll Be Back...");
        }
    }
}
