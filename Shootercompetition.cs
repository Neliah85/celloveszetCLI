using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI
{
    public class ShooterCompetition
    {
        
        public List<Shooter> Shooters { get; set; }

       
        public ShooterCompetition(List<Shooter> shooters)
        {
            Shooters = shooters;
        }

        
        public void FindBestShooter()
        {
            Shooter bestShooter = null;
            int bestScore = -1;

            foreach (var shooter in Shooters)
            {
                int highestShot = shooter.HighestShot(); 
                if (highestShot > bestScore)
                {
                    bestScore = highestShot;
                    bestShooter = shooter;
                }
            }

            Console.WriteLine($"Legjobb lövő: {bestShooter.Name}");
            Console.WriteLine($"Lövések: {string.Join(", ", bestShooter.Shots)}");
        }

        
        public void FindWeakestShooter()
        {
            Shooter weakestShooter = null;
            double lowestAvg = double.MaxValue;

            foreach (var shooter in Shooters)
            {
                double avgScore = shooter.AverageScore(); 
                if (avgScore < lowestAvg)
                {
                    lowestAvg = avgScore;
                    weakestShooter = shooter;
                }
            }

            Console.WriteLine($"Leggyengébb átlagú lövő: {weakestShooter.Name}");
            Console.WriteLine($"Átlag pontszám: {lowestAvg:F2}");
        }
    }

}
