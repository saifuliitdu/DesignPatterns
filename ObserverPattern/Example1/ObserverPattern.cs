using System;
using System.Collections.Generic;

namespace ObserverPattern.Example1
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void UnregisterObserver(Observer o);
        void NotifyObservers();
    }
    public interface Observer
    {
        void Update(int runs, int wickets, float overs);
    }
    public class CricketDataOP : Subject
    {
        int runs;
        int wickets;
        float overs;
        List<Observer> observerList;
        public CricketDataOP()
        {
            observerList = new List<Observer>();
        }
        public void NotifyObservers()
        {
            observerList.ForEach(x => x.Update(runs, wickets, overs));
        }

        public void RegisterObserver(Observer o)
        {
            observerList.Add(o);
        }

        public void UnregisterObserver(Observer o)
        {
            observerList.Remove(o);
        }
        // get latest runs from stadium 
        private int getLatestRuns()
        {
            // return 90 for simplicity 
            return 90;
        }

        // get latest wickets from stadium 
        private int getLatestWickets()
        {
            // return 2 for simplicity 
            return 2;
        }

        // get latest overs from stadium 
        private float getLatestOvers()
        {
            // return 90 for simplicity 
            return (float)10.2;
        }

        // This method is used update displays 
        // when data changes 
        public void dataChanged()
        {
            //get latest data 
            runs = getLatestRuns();
            wickets = getLatestWickets();
            overs = getLatestOvers();

            NotifyObservers();
        }
    }

    public class AverageScoreDisplayOP : Observer
    {
        private float runRate;
        private int predictedScore;

        public void Update(int runs, int wickets,
                           float overs)
        {
            this.runRate = (float)runs / overs;
            this.predictedScore = (int)(this.runRate * 50);
            display();
        }

        public void display()
        {
            Console.WriteLine("\nAverage Score Display: \n"
                               + "Run Rate: " + runRate +
                               "\nPredictedScore: " +
                               predictedScore);
        }
    }

    public class CurrentScoreDisplayOP : Observer
    {
        private int runs, wickets;
        private float overs;

        public void Update(int runs, int wickets,
                           float overs)
        {
            this.runs = runs;
            this.wickets = wickets;
            this.overs = overs;
            display();
        }

        public void display()
        {
            Console.WriteLine("\nCurrent Score Display:\n"
                               + "Runs: " + runs +
                               "\nWickets:" + wickets +
                               "\nOvers: " + overs);
        }
    }
}

