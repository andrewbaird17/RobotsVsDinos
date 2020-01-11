using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVsRobots
{
    class Herd
    {
        // member variables (HAS A)

        // below three lines from first attempt before instantiating each Dino into a list
        //public Dinosaur small;
        //public Dinosaur medium;
        //public Dinosaur large;

        public List<Dinosaur> dinosaurs;
        public Dinosaur CurrentDino;
        public string compInput;

        // constructor (SPAWNER)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            // instantiate dinosaur classes when herd is instantiated
            dinosaurs.Add(new Dinosaur("Smallie", 300, 50, 25));
            dinosaurs.Add(new Dinosaur("Mediumie", 200, 25, 50));
            dinosaurs.Add(new Dinosaur("Largeie", 100, 30, 75));
        }
        // member methods (CAN DO)
        public void ChooseDino()
        {
            List<string> types = new List<string>();
            for (int i = 0; i < dinosaurs.Count; i++)
            {
                // remove robot from list if health is at or below 0
                if (dinosaurs[i].health <= 0)
                {
                    dinosaurs.RemoveAt(i);
                }

            }
            // make a list of available robots to fight
            for (int j = 0; j < dinosaurs.Count; j++)
            {
                types.Add(dinosaurs[j].type);
            }
            // have comp select their dino to battle
            
            for (int k = 0; k < types.Count; k++)
            {
                Random random = new Random();
                int index = random.Next(types.Count);

                compInput = types[index].ToLower();
            }


            // clear console screen (reset the memory)
            Console.Clear();
            // Find the name of the robot chosen in the list of robots that are still alive and send it out to fight
            foreach (var item in dinosaurs)
            {
                if (compInput == item.type.ToLower())
                {
                    CurrentDino = item;
                }
            }
            // Below comments are how the computer orginally chose its dino to fight
            ////Make the computer randomly choose its dinosaur to fight
            //List<string> dinonames = new List<string>() {"Smallie", "Mediumie", "Largeie"};
            //Random random = new Random();
            //int index = random.Next(dinonames.Count);

            //string compinput = dinonames[index];

            //switch (compinput)
            //{
            //    // "Smallie"
            //    case "Smallie":
            //        CurrentDino = dinosaurs[0];
            //        break;
            //    // "Mediumie"
            //    case "Mediumie":
            //        CurrentDino = dinosaurs[1];
            //        break;
            //    // "Largeie"
            //    case "Largeie":
            //        CurrentDino = dinosaurs[2];
            //        break;
            //    default:
            //        break;
            //}
        }

    }
}
