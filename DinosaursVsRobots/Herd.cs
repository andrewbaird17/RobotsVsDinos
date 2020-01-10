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

        // constructor (SPAWNER)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            // instantiate dinosaur classes when herd is instantiated
            dinosaurs.Add(new Dinosaur("Smallie", 100, 50, 25));
            dinosaurs.Add(new Dinosaur("Mediumie", 200, 25, 50));
            dinosaurs.Add(new Dinosaur("Largeie", 300, 30, 75));
        }
        // member methods (CAN DO)
        public void ChooseDino()
        {
            // Make the computer randomly choose its dinosaur to fight
            List<string> dinonames = new List<string>() {"Smallie", "Mediumie", "Largeie"};
            Random random = new Random();
            int index = random.Next(dinonames.Count);
            
            string compinput = dinonames[index].ToLower();

            switch (compinput)
            {
                // "Smallie"
                case "smallie":
                    CurrentDino = dinosaurs[0];
                    break;
                // "Mediumie"
                case "mediumie":
                    CurrentDino = dinosaurs[1];
                    break;
                // "Largeie"
                case "largeie":
                    CurrentDino = dinosaurs[2];
                    break;
                default:
                    break;
            }
        }

    }
}
