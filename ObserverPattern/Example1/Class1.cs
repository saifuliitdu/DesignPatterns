using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Example1
{
    public class CricketData
    {
        int runs, wickets;
        float overs;
        CurrentScoreDisplay currentScoreDisplay;
        AverageScoreDisplay averageScoreDisplay;
        public CricketData(CurrentScoreDisplay currentScoreDisplay, AverageScoreDisplay averageScoreDisplay)
        {
            this.currentScoreDisplay = currentScoreDisplay;
            this.averageScoreDisplay = averageScoreDisplay;
        }
        // Get latest runs from stadium 
        private int getLatestRuns()
        {
            // return 90 for simplicity 
            return 90;
        }

        // Get latest wickets from stadium 
        private int getLatestWickets()
        {
            // return 2 for simplicity 
            return 2;
        }

        // Get latest overs from stadium 
        private float getLatestOvers()
        {
            // return 10.2 for simplicity 
            return (float)10.2;
        }
        // This method is used update displays when data changes 
        public void dataChanged()
        {
            // get latest data 
            runs = getLatestRuns();
            wickets = getLatestWickets();
            overs = getLatestOvers();

            currentScoreDisplay.update(runs, wickets, overs);
            averageScoreDisplay.update(runs, wickets, overs);
        }
    }

    public class CurrentScoreDisplay
    {
        private float runRate;
        private int predictedScore;

        public void update(int runs, int wickets, float overs)
        {
            this.runRate = (float)runs / overs;
            this.predictedScore = (int)(this.runRate * 50);
            display();
        }

        public void display()
        {
            Console.WriteLine("\nAverage Score Display:\n" +
                               "Run Rate: " + runRate +
                               "\nPredictedScore: " + predictedScore);
        }
    }
    public class AverageScoreDisplay
    {
        private int runs, wickets;
        private float overs;

        public void update(int runs, int wickets, float overs)
        {
            this.runs = runs;
            this.wickets = wickets;
            this.overs = overs;
            display();
        }

        public void display()
        {
            Console.WriteLine("\nCurrent Score Display: \n" +
                               "Runs: " + runs + "\nWickets:"
                               + wickets + "\nOvers: " + overs);
        }
    }
}
