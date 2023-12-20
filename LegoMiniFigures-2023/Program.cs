using LegoMiniFigures_2023.Heads;
using System;

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

            constructionHead.SayHi();
            batmanhead.SayHi();
            astroHead.SayHi();

        }
    }
}