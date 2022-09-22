using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Monkey : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine($"The {Name} proceeds to screech as loud as it possibly can. ");
        }

        public override void Sleep()
        {
            base.Sleep();
        }
    }
}
