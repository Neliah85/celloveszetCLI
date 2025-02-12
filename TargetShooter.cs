using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI
{
    public class TargetShooter
    {
       
        public string Name { get; private set; }
        public int FirstShot { get; private set; }
        public int SecondShot { get; private set; }
        public int ThirdShot { get; private set; }
        public int FourthShot { get; private set; }

       
        public TargetShooter(string data)
        {
            
            var parts = data.Split(';');
            Name = parts[0];
            FirstShot = int.Parse(parts[1]);
            SecondShot = int.Parse(parts[2]);
            ThirdShot = int.Parse(parts[3]);
            FourthShot = int.Parse(parts[4]);
        }

        
        public int GetHighestScore()
        {
            return Math.Max(Math.Max(FirstShot, SecondShot), Math.Max(ThirdShot, FourthShot));
        }
    }

}
