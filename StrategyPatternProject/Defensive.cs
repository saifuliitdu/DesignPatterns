using System;

namespace StrategyPatternProject
{
    public class Defensive : IFighter
    {
        public void Fight()
        {
            Console.WriteLine("Fighter is now in defensie mood");
        }
    }
}
