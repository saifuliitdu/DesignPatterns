using ObserverPattern.Example1;
using System;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create objects for testing 
            AverageScoreDisplay averageScoreDisplay =
                                           new AverageScoreDisplay();
            CurrentScoreDisplay currentScoreDisplay =
                                           new CurrentScoreDisplay();

            // Pass the displays to Cricket data 
            CricketData cricketData = new CricketData(currentScoreDisplay,
                                                      averageScoreDisplay);

            // In real app you would have some logic to call this 
            // function when data changes 
            // Problem Example
            cricketData.dataChanged();
            Console.WriteLine("Problem Example Output End");
            Console.WriteLine("Problem Solution with Observer Pattern");
            Console.WriteLine();

            // create objects for testing 
            AverageScoreDisplayOP averageScoreDisplayOP =
                              new AverageScoreDisplayOP();
            CurrentScoreDisplayOP currentScoreDisplayOP =
                              new CurrentScoreDisplayOP();

            // pass the displays to Cricket data 
            CricketDataOP cricketDataOP = new CricketDataOP();

            // register display elements 
            cricketDataOP.RegisterObserver(averageScoreDisplayOP);
            cricketDataOP.RegisterObserver(currentScoreDisplayOP);

            // in real app you would have some logic to 
            // call this function when data changes 
            cricketDataOP.dataChanged();

            //remove an observer 
            cricketDataOP.UnregisterObserver(averageScoreDisplayOP);

            // now only currentScoreDisplay gets the 
            // notification 
            cricketDataOP.dataChanged();
        }
    }


}
