using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVsRobots
{
    class Battlefield
    {
        // member variables (HAS A)
        public Herd herd;
        public Fleet fleet;
        int counter;

        // constructor (SPAWNER)
        public Battlefield()
        {
            // instantiate the overall "armies" for each side
            herd = new Herd();
            fleet = new Fleet();
            // start a counter at 1 for mistyped choose robot
            //counter = 1;
        }
        // member methods (CAN DO)

        public void RunSim()
        {
            // give user some background on the game story
            Console.WriteLine("Welcome to Dinosaurs vs Robots!");
            Console.WriteLine("Dinosaurs have come back to life and are threatenting human existence.");
            Console.WriteLine("The greatest minds have assembled and created the world's top line defense against these dinosaurs.");
            Console.WriteLine("You have been chosen to run this team of robots and are humanity's last hope. Good Luck!");
            Console.ReadLine();
            fleet.ChooseRobot();
            herd.ChooseDino();
            DisplayScreen();
        }

        public void DisplayScreen()
        {
            Console.Clear();
            // Display Computer's (Dinosaur's): Type, Health, Energy

            Console.WriteLine("Computer Chose: " + herd.CurrentDino.type);
            Console.WriteLine("Current Health: " + herd.CurrentDino.health);
            Console.WriteLine("Current Energy: " + herd.CurrentDino.energy);
            Console.WriteLine("");

            // Display User's Robot Choice: Name, Health, powerLevel
            Console.WriteLine("You Chose: " + fleet.CurrentFighter.name) ;
            Console.WriteLine("Current Health: " + fleet.CurrentFighter.health);
            Console.WriteLine("Current Power Level: " + fleet.CurrentFighter.powerLevel);
            Console.ReadLine();

        }
    }
}

