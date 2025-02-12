using System;

public class ShootingResult
{
    public string Name { get; private set; }
    public int FirstShot { get; private set; }
    public int SecondShot { get; private set; }
    public int ThirdShot { get; private set; }
    public int FourthShot { get; private set; }

    
    public ShootingResult(string name, string firstShot, string secondShot, string thirdShot, string fourthShot)
    {
        Name = name;
        FirstShot = int.Parse(firstShot);
        SecondShot = int.Parse(secondShot);
        ThirdShot = int.Parse(thirdShot);
        FourthShot = int.Parse(fourthShot);
    }

    
    public int GetMaxShot()
    {
        return Math.Max(Math.Max(FirstShot, SecondShot), Math.Max(ThirdShot, FourthShot));
    }

    
    public double GetAverage()
    {
        return (FirstShot + SecondShot + ThirdShot + FourthShot) / 4.0;
    }
}
