using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures_2023.Heads
{
    internal class AstronautHead
    {
        public LegoColor Color { get; set; }
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }



        public void SayHi()
        {
            Console.WriteLine("Marjor Tom to Ground Control...");
        }

        public void Spin()
        {
            Console.WriteLine("The Astronaut head spins to take in the beauty of the cosmos...");
        }


        public void Shave() // Sets enum to default value //
        {
            Console.WriteLine($"The Astronaut head shaves its {FacialHair}.");
            FacialHair = FacialHair.None;
        }



    }
}
