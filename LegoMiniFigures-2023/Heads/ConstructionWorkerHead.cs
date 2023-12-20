using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures_2023.Heads
{
    class ConstructionWorkerHead
    {
        public bool HasMullet { get; set; }
        public LegoColor Color { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }


        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat; // sets WearingHardHat to the opposite of itself //
            Console.WriteLine($"The Construction Worker Head{(WearingHardHat ? "is" : " is not ")} wearing it's hard hat");
            return WearingHardHat; // returns the result of set operation above //
        }


        
        public void Spin()
        {
            if (NumberOfTeeth > 0) // If you have teeth, you can lose them, if not you can lose anymore teeth //
            {
                NumberOfTeeth -= 1; // When this happens, the worker loses a tooth //
            }
            Console.WriteLine($"The {Color} Construction Worker Hat spins after being hit by a girder.");
        }

        public void SayHi()
        {
            Console.WriteLine("The Construction Worker Head says hello.");
        }


    }

    // Enum // 
    // Not Classes // it is a struct
    // All about what possible values there could be for a given thing //
    // Under the covers it's just an integer //
    // Sometimes they are made where tey are used. Like if it's only in the ConstructionWorkerHead class, then it makes sense to just leave it here. But if it I use it again, like in the BatManHead Class, then I move it to it's own class file //


    /*enum LegoColor*/
    /*{*/
    /*    Yellow,*/
    /*    White,*/
    /*    Brown,*/
    /*    Green,*/
    /*    Red,*/
    /*    Black*/
    /*}*/
    // Enum // 
}
