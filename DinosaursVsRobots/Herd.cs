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
            Console.WriteLine("Pick your opponent: Smallie, Mediumie, Largie");
            string compinput = Console.ReadLine().ToLower();

            switch (compinput)
            {
                case "smallie":
                    CurrentDino = dinosaurs[0];
                    break;
                case "mediumie":
                    CurrentDino = dinosaurs[1];
                    break;
                case "largie":
                    CurrentDino = dinosaurs[2];
                    break;
                default:
                    break;
            }
        }

    }
}
