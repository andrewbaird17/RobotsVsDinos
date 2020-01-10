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

        // below three lines from first attempt before instantiating each Dino into a list
        //public Robot tiny;
        //public Robot normal;
        //public Robot big;

        public List<Robot> robots;
        public Robot CurrentFighter;
        public int counter;

        // constructor (SPAWNER)
        public Fleet()
        {
            robots = new List<Robot>();
            counter = 1;
            // instantiate robot classes when Fleet is instantiated
            robots.Add(new Robot("Tiny", 100, 50, 25));
            robots.Add(new Robot("Normal", 200, 75, 50));
            robots.Add(new Robot("Big", 300, 25, 75));
        }

        // member methods (CAN DO)

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
                    CurrentFighter = robots[0];
                    break;
                case "normal":
                    CurrentFighter = robots[1];
                    break;
                case "big":
                    CurrentFighter = robots[2];
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
        
    }
}

