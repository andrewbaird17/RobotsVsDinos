using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVsRobots
{
    class Simulation
    {
        // member variables (HAS A)
        int counter;

        // constructor (SPAWNER)
        public Simulation()
        {
            counter = 1;
        }

        // member methods (CAN DO)
        public void RunSim()
        {
            Console.WriteLine("Welcome to Dinosaurs vs Robots!");
            Console.WriteLine("Dinosaurs have come back to life and are threatenting human existence.");
            Console.WriteLine("The greatest minds have assembled and created the world's top line defense against these dinosaurs.");
            Console.WriteLine("You have been chosen to run this team of robots and are humanity's last hope. Good Luck!");
            ChooseRobot();
        }

        public void ChooseRobot()
        {
            Console.WriteLine("Choose Your Robot: Tiny, Normal, Big");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "Tiny":

                    break;
                case "Normal":
                    break;
                case "Big":
                    break;
                default:
                    IdiotProofChoice();
                    break;
            }
        }
        public void IdiotProofChoice()
        {
            if (counter <= 3)
            {
                counter += 1;
                ChooseRobot();
            }
            else
            {
                // Add in final game screen to end program
                Console.WriteLine("You have failed humanity!\n Hit any key to EXIT");
            }
        }
    }
}
