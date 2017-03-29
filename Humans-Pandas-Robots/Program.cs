using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans_Pandas_Robots
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("We are beginning this new exercise.");

            var terminator = new Robots ("Arnold");

            var robotList = new List<Robots>();
            robotList.Add(terminator);

            //Console.WriteLine($"{terminator.DisplayGreeting}");

            var creatureList = new List<Creatures>
            {
                terminator
            };

            foreach (var robotic in robotList)
            {
                robotic.DisplayGreeting();
            }
        }
    }
}
