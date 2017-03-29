using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humans_Pandas_Robots
{
    abstract class Creatures
    {
        public Creatures (string type)
        {
            Console.WriteLine($"The type of creature created is {CreatureType}");
            CreatureType = type;
        }

        public string CreatureType { get; set; }
        public string Name { get; set; }


        // Our Two Methods
        public void DisplayName ()
        {
            Console.WriteLine(this.CreatureType);
        }
        public void DisplayGreeting()
        {
            Console.WriteLine($"Hello, my name is: {this.Name}!");
        }
    }
}
