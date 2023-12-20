using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures_2023.Heads
{
    class BatmanHead : HeadBase
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpresson { get; set; } = "Stoic";

        public BatmanHead()
        {
            Color = LegoColor.Black;
        }



        public void Spin()
        {
            Console.WriteLine("Where is the joker!?!?");
        }

        public override void SayHi() // Allows us to change the behavior of the base class SayHi method // - Needs the keyword OVERRIDE // - Intentionally changing the wau this behavor works // Can only override method inside of the inherity class //
        {
            Console.WriteLine("I'm Batman!");
        }




    }
}
