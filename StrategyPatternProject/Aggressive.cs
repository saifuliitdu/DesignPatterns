using System;

namespace StrategyPatternProject
{
    class Aggressive : IFighter
    {
        public void Fight()
        {
            Console.WriteLine("Fighter is now in aggresive mood");
        }
    }
}
