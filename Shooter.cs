using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace celloveszetCLI
{
    public class Shooter
    {
        
        public string Name { get; set; }

        
        public List<int> Shots { get; set; }

       
        public Shooter(string name, List<int> shots)
        {
            Name = name;
            Shots = shots;
        }

        public int HighestShot()
        {
            return Shots.Max();
        }

        
        public double AverageScore()
        {
            return Shots.Average();
        }
    }

}
