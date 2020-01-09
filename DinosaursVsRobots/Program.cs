using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVsRobots
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulation sim = new Simulation();

            // run story game
            sim.RunSim();
            Console.ReadLine();

        }
    }
}
