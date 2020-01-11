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

        // constructor (SPAWNER)
        public Battlefield()
        {
            // instantiate the overall "armies" for each side
            herd = new Herd();
            fleet = new Fleet();
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
            // user chooses a robot
            fleet.ChooseRobot();
            // computer chooses a robot
            herd.ChooseDino();
            // Display stats

            DisplayScreen();

        }

        public void DisplayScreen()
        {
            Console.Clear();
            // Display Computer's (Dinosaur's): Type, Health, Energy

            Console.WriteLine("Computer Chose: " + herd.CurrentDino.type);
            Console.WriteLine("Current Health: " + herd.CurrentDino.health);
            Console.WriteLine("Current Attack Power: " + herd.CurrentDino.attackPower);
            Console.WriteLine("");

            // Display User's Robot Choice: Name, Health, powerLevel
            Console.WriteLine("You Chose: " + fleet.CurrentFighter.name);
            Console.WriteLine("Current Health: " + fleet.CurrentFighter.health);
            Console.WriteLine("Current Attack Power: " + fleet.CurrentFighter.attackPower);
            Console.ReadLine();

            // Inititate the Fight
            TurnSequence();
        }

        public void PlayerChoice()
        {
            Console.WriteLine(fleet.CurrentFighter.name + " attacks " + herd.CurrentDino.type);
            // Console.WriteLine("Choose an option: Attack or Dodge")
            string robotAttack = "Attack";
            switch (robotAttack)
            {
                case "Attack":
                    AttackDinoSequence();

                    break;
                default:
                    Console.Clear();
                    DisplayScreen();
                    break;
            }

        }

        public void ComputerChoice()
        {
            // Add in "Dodge" as an option later once basic game works
            List<string> options = new List<string>() { "Attack" };
            Random random = new Random();
            int index = random.Next(options.Count);

            string compinput = options[index].ToLower();
            switch (compinput)
            {
                case "attack":
                    AttackRobotSequence();
                    break;
                default:
                    break;
            }
        }

        public void TurnSequence()
        {
            if (fleet.CurrentFighter.health > 0 && herd.CurrentDino.health > 0)
            {
                PlayerChoice();
                ComputerChoice();
                DisplayScreen();
                Console.ReadLine();
                Console.Clear();
            }
            else if (herd.dinosaurs.Count == 0)
            {
                WinnerMessage();
            }
            else if (fleet.robots.Count == 0)
            {
                LoserMessage();
            }
            else if (fleet.CurrentFighter.health <= 0)
            {
                Console.WriteLine(fleet.CurrentFighter.name + " has zero health.");
                fleet.ChooseRobot();
                DisplayScreen();
            }
            else if (herd.CurrentDino.health <= 0)
            {
                Console.WriteLine(herd.CurrentDino.type + " has zero health.");
                herd.ChooseDino();
                DisplayScreen();
            }
            else
            {

            }


        }

        public void WinnerMessage()
        {
            Console.WriteLine("You have successfully defeated the dinosaurs! Humanity can rest in peace for now...");
            Console.ReadLine();
            Console.WriteLine("Hit any key to Exit");
            Console.ReadLine();
        }

        public void LoserMessage()
        {
            Console.WriteLine("All of your robots are dead. You have failed humanity! Hit any button to Exit");
            Console.ReadLine();

        }
        public void AttackDinoSequence()
        {
            fleet.CurrentFighter.health -= herd.CurrentDino.attackPower;
        }

        public void AttackRobotSequence()
        {
            herd.CurrentDino.health -= fleet.CurrentFighter.attackPower;
        }

    }
}

