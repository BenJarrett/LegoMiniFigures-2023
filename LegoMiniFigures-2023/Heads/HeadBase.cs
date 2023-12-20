using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMiniFigures_2023.Heads
{
    // where we put stuff that the other heads have in common //
    // Going to make all the other classes inherit from this class //
    // *** ABSTRACT CLASS *** // - This class is not intented to be obstantiated. // 
    // The idea of a thing, but it's not actually a thing //
    // ABSTRACT CLASS // Marking this as abstract, means that this class is only good to inherit from. //
    // Once a class is marked as ABSTRACT, you can do things like defining the idea of a method // 
    // *** ABSTRACT CLASS *** // - The Idea of a class //

    abstract class HeadBase
    {
        public LegoColor Color { get; set; }


        // *** VIRTUAL METHOD *** // - People that inherit from me can change me // 
        // This methiod's behavior can be changed by a class that inherits from me //
        // Doesn't have be changed, but it can be changed //
        // We want a base behavior of saying hi to look like this // 
        // If a head has it's own custom SayHi method, we make it Virtual //
        public virtual void SayHi()
        {
            // Default way to greet people //
            Console.WriteLine("Hi.");
        }
        // *** VIRTUAL METHOD *** //

        // *** ABSTRACT METHOD *** //
        // The Idea of a Method // 
        // Public Abstract Method that Doesn't rturn anything and is called Spin() // 
        // What we define here is saying every class that inherits from the abstract class of HeadBase, must have a method that looks like this // 
        // We don't know what this Spin() Method should do, but I know that every class that inherits from it should have one //
        public abstract void Spin();
        // The Idea of a Method //  
        // *** ABSTRACT METHOD *** //
    }
}
