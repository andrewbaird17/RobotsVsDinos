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
            List<string> names = new List<string>();
            for (int i = 0; i < robots.Count; i++)
            {
                if (robots[i].health == 0)
                {
                    robots.RemoveAt(i);
                }
            }
            for (int j = 0; j < robots.Count; j++)
            {
                names.Add(robots[j].name);
            }
            // have user select their first robot to battle
            Console.WriteLine("Choose your robot: ");
            for (int k = 0; k < names.Count; k++)
            {
                Console.Write(names[k] + " \n");
            }

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

