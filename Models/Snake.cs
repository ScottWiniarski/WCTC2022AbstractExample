using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Snake : Animal
    {
        public override void Sleep()
        {
            Console.WriteLine($"Appears to be sleeping, but with reptiles you never know.");
        }
        public override void MakeNoise()
        {
            Console.WriteLine($"It hisses and rattles its' tail.");
        }
    }
}
