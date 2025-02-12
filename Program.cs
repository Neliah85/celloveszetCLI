using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static List<ShootingResult> ReadFile(string filename)
    {
        var shooters = new List<ShootingResult>();

        using (var reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var data = line.Split(';');
                var shooter = new ShootingResult(data[0], data[1], data[2], data[3], data[4]);
                shooters.Add(shooter);
            }
        }
        return shooters;
    }
    public static void Main(string[] args)
    {
        var shooters = ReadFile("lovesek.csv");

       
        DisplayBestShooter(shooters);

        
        DisplayWeakestShooter(shooters);

        Console.WriteLine("\nJátékosok legnagyobb lövései:");
        foreach (var shooter in shooters)
        {
            Console.WriteLine($"{shooter.Name}: {shooter.GetMaxShot()}");
        }
    }
    public static void DisplayBestShooter(List<ShootingResult> shooters)
    {
        var bestShooter = shooters[0];
        foreach (var shooter in shooters)
        {
            if (shooter.GetMaxShot() > bestShooter.GetMaxShot())
            {
                bestShooter = shooter;
            }
        }
        Console.WriteLine($"Legjobb lövő: {bestShooter.Name}, legnagyobb lövése: {bestShooter.GetMaxShot()}");
    }

    public static void DisplayWeakestShooter(List<ShootingResult> shooters)
    {
        var weakestShooter = shooters[0];
        foreach (var shooter in shooters)
        {
            if (shooter.GetAverage() < weakestShooter.GetAverage())
            {
                weakestShooter = shooter;
            }
        }
        Console.WriteLine($"Leggyengébb átlagú lövő: {weakestShooter.Name}, átlag: {weakestShooter.GetAverage():0.00}");
    }

}
