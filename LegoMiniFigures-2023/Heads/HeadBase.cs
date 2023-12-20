using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures_2023.Heads
{
    // where we put stuff that the other heads have in common //
    // Going to make all the other classes inherit from this class //
    class HeadBase
    {
        public LegoColor Color { get; set; }


        // Virtual // - People that inherit from me can change me // 
        // This methiod's behavior can be changed by a class that inherits from me //
        // Doesn't have be changed, but it can be changed //
        // We want a base behavior of saying hi to look like this // 
        // If a head has it's own custom SayHi method, we make it Virtual //
        public virtual void SayHi()
        {
            // Default way to greet people //
            Console.WriteLine("Hi.");
        }
    }
}
