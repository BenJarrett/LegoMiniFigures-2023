using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures_2023.Heads
{
    class BatmanHead
    {
        public bool IsWearingMask { get; set; }
        public string Version { get; set; }
        public string FacialExpresson { get; set; } = "Stoic";
        public LegoColor Color => LegoColor.Black;




        public void Spin()
        {
            Console.WriteLine("Where is the joker!?!?");
        }

        public void SayHi()
        {
            Console.WriteLine("I'm Batman!");
        }




    }
}
