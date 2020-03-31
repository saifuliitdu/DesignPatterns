using System;

namespace StrategyPatternProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var fighter = new Fighter();
            var random = new Random();

            Console.Write("Please insert health: ");
            int input = Convert.ToInt32(Console.ReadLine());
            while (input > 0 && input <= 100)
            {
                fighter.Health = input;


                if (fighter.Health <= 50)
                    fighter.ChangeMood(new Defensive());
                else if (fighter.Health > 50 && fighter.Health <= 90)
                    fighter.ChangeMood(new Aggressive());
                else if (fighter.Health > 90)
                    fighter.ChangeMood(new SuperAggressive());

                Console.Write("Please insert health: ");
                input = Convert.ToInt32(Console.ReadLine());
                
            }

            //Console.ReadKey();
        }
    }
}
