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
            counter = 1;
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
            ChooseRobot();
        }

        public void ChooseRobot()
        {
            // have user select their first robot to battle
            Console.WriteLine("Choose Your Robot: Tiny, Normal, Big");
            string userInput = Console.ReadLine().ToLower();
            // clear console screen (reset the memory)
            Console.Clear();
            switch (userInput)
            {
                case "tiny":
                    DisplayScreen(userInput);
                    break;
                case "normal":

                    break;
                case "big":

                    break;
                default:
                    MistypedChoice();
                    break;
            }
        }
        public void MistypedChoice()
        {
            // keep track of failed entries and end program if too many attempts
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
        public void DisplayScreen(string userInput)
        {
            Console.Clear();
            // Display Computer's (Dinosaur's): Type, Health, Energy
            Console.WriteLine("Computer Chose:");
            Console.WriteLine("Current Health: ");
            Console.WriteLine("Current Energy: ");
            Console.WriteLine("");

            // Display User's Robot Choice: Name, Health, powerLevel
            Console.WriteLine("You Chose: " + userInput);
            Console.WriteLine("Current Health: ");
            Console.WriteLine("Current Power Level: ");

        }
    }
}

