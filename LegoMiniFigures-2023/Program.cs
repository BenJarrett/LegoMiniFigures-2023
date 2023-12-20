using LegoMiniFigures_2023.Heads;
using System;
using System.Collections.Generic;

namespace LegoMiniFigures_2023
{
    class Program
    {
        static void Main(string[] args)
        {


            var constructionHead = new ConstructionWorkerHead();
            var batmanhead = new BatmanHead();
            var astroHead = new AstronautHead();


            constructionHead.Color = LegoColor.Yellow;

            /*constructionHead.SayHi();
            batmanhead.SayHi();
            astroHead.SayHi();*/

            // Doesn't work bc we make the HeadBase Class abstract // It is now only used to be inherited from //
            /*var weirdHead = new HeadBase();*/

            // **** POLYMORHISM **** // - Ability to treat dis-similar things based on their similarities //
            // *** Benifits of having 'IS A' inheritence relationship *** //
            // Having that "Is A" relationship from Inheritence lets you do some cool things //
            // If all the variables uptop have that ' IS A ' relationship with something, you can talk about them in a lowest commond denominator type of way //
            // Now I can take these different things that don't work the same way, and I can put them all into one collection of things. Knowing that they are all HeadBases //
            // Now, instead of using these heads like below 
            /*constructionHead.SayHi();
            batmanhead.SayHi();
            astroHead.SayHi();*/
            // Anything that's not on the base class, will not work like this. It will need to be like the other way //
            // I can call a foreach loop //
            var heads = new List<HeadBase>() { astroHead, batmanhead, constructionHead };
            foreach (var head in heads)
            {
                head.SayHi();
                head.Spin();
            }
            // *** Benifits of having 'IS A' inheritence relationship *** //
            // **** POLYMORHISM **** // - Ability to treat dis-similar things based on their similarities //
        }
    }
}