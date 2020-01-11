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
            robots.Add(new Robot("Tiny", 300, 50, 25));
            robots.Add(new Robot("Normal", 200, 75, 50));
            robots.Add(new Robot("Big", 100, 25, 75));
        }

        // member methods (CAN DO)

        public void ChooseRobot()
        {
            List<string> names = new List<string>();
            for (int i = 0; i < robots.Count; i++)
            {
                // remove robot from list if health is at or below 0
                if (robots[i].health <= 0)
                {
                    robots.RemoveAt(i);
                }
                
            }
            // make a list of available robots to fight
            for (int j = 0; j < robots.Count; j++)
            {
                names.Add(robots[j].name);
            }
            // have user select their robot to battle
            Console.WriteLine("Choose your robot: ");
            for (int k = 0; k < names.Count; k++)
            {
                Console.Write(names[k] + " \n");
            }

            string userInput = Console.ReadLine().ToLower();

            // clear console screen (reset the memory)
            Console.Clear();
            // Find the name of the robot chosen in the list of robots that are still alive and send it out to fight
            foreach (var item in robots)
            {
                if (userInput == item.name.ToLower())
                {
                    CurrentFighter = item;
                }
                //else
                //{
                //    MistypedChoice();
                //}
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
                Console.ReadLine();
            }
        }
        
    }
}

