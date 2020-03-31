using System;

namespace StrategyPatternProject
{
    public class SuperAggressive : IFighter
    {
        public void Fight()
        {
            Console.WriteLine("Fighter is now super aggressive mood.");
        }
    }
}
