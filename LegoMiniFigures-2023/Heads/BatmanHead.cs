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


        // Abstract Method Override // 
        // Still need to user the override keyword to define the behavior of the headbase Abstract method Spin() //
        public override void Spin()
        {
            Console.WriteLine("Where is the joker!?!?");
        }
        // Abstract Method Override //

        public override void SayHi() // Allows us to change the behavior of the base class SayHi method // - Needs the keyword OVERRIDE // - Intentionally changing the wau this behavor works // Can only override method inside of the inherity class //
        {
            Console.WriteLine("I'm Batman!");
        }




    }
}
