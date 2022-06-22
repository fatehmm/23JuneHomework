using System;
using System.Collections.Generic;

namespace _22JunePracticw
{
    public class F1Race
    {
        public F1Race()
        {
        }
        List<Car> Cars = new List<Car>();
        public DateTime RaceStartDate;
        public DateTime RaceEndDate;

        public List<Car> CompletedCars()
        {
            TimeSpan raceDuration = RaceEndDate - RaceStartDate;

            List<Car> completedCars = Cars.FindAll(x => x.RaceDurationMinutes < raceDuration);
 
            return completedCars;
        }

        public void GetWinner()
        {
            Car winner = Cars[0];
            for (int i = 1; i < Cars.Count; i++)
            {
                if (Cars[i].RaceDurationMinutes < winner.RaceDurationMinutes)
                {
                    winner = Cars[i];
                }
            }
            Console.WriteLine($"{winner.No} nomreli {winner.Brand} masini yarisi {winner.RaceDurationMinutes} deqiqe ile qalib oldu");
        }



    }
}

