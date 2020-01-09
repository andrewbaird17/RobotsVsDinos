using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVsRobots
{
    class Fleet
    {
        // member variables (HAS A)
        public Robot tiny;
        public Robot normal;
        public Robot big;
        public List<Robot> robots;

        // constructor (SPAWNER)
        public Fleet()
        {
            robots = new List<Robot>();
            robots.Add(new Robot("Tiny", 100, 50, 25));
            robots.Add(new Robot("Normal", 200, 75, 50));
            robots.Add(new Robot("Big", 300, 25, 75));
        }

        // member methods (CAN DO)
        
    }
}
