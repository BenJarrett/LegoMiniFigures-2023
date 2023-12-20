using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures_2023.Heads
{
    class AstronautHead : HeadBase
    {
        public bool WearingHelmet { get; set; }
        public FacialHair FacialHair { get; set; }


        // Taking the base class behivior and adding to it //
        public override void SayHi()
        {
            // Base - means let me interact directly with the thing that I am inheriting from // Inside of this overwriten method, I am going to call the base class say hi method, and then do something else //
            base.SayHi(); 
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
