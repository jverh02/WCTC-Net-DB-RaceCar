using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceTrack.RaceTrack.Cars
{
    class Ferrari : RaceCar
    {
       public Ferrari()
       {
            Name = "Ferrari F40";
            TopSpeed = 130;
       }
       public override void StartEngine()
        {
            Console.WriteLine($"The {Name} starts its engine!");
        }
        public override void Brake()
        {
            Console.WriteLine($"The {Name} ends in position {Position}!");
        }
        public override void StopEngine()
        {
            Console.WriteLine($"The {Name}'s engine goes quiet.");
        }

    }
}
