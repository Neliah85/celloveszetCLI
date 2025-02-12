using celloveszetCLI;
using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
       
        string filePath = "lovesek.csv";

        
        List<TargetShooter> shooters = new List<TargetShooter>();

      
        using (StreamReader sr = new StreamReader(filePath))
        {
            while (!sr.EndOfStream)
            {
                var line = sr.ReadLine();  
                var shooter = new TargetShooter(line); 
                shooters.Add(shooter); 
            }
        }

        
        foreach (var shooter in shooters)
        {
            Console.WriteLine($"{shooter.Name}: {shooter.GetHighestScore()}");
        }
    }

    public static void FindBestShooter(List<Shooter> shooters)
    {
        Shooter bestShooter = null;
        int bestScore = -1;

        foreach (var shooter in shooters)
        {
            int highestShot = shooter.Shots.Max(); 
            if (highestShot > bestScore)
            {
                bestScore = highestShot;
                bestShooter = shooter;
            }
        }

        Console.WriteLine($"Legjobb lövő: {bestShooter.Name}");
        Console.WriteLine($"Lövések: {string.Join(", ", bestShooter.Shots)}");
    }

    public static void FindWeakestShooter(List<Shooter> shooters)
    {
        Shooter weakestShooter = null;
        double lowestAvg = double.MaxValue;

        foreach (var shooter in shooters)
        {
            double avgScore = shooter.Shots.Average(); 
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
