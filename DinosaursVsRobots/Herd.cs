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
        //public Dinosaur small;
        //public Dinosaur medium;
        //public Dinosaur large;
        public List<Dinosaur> dinosaurs;
        // constructor (SPAWNER)
        public Herd()
        {
            dinosaurs = new List<Dinosaur>();
            dinosaurs.Add(new Dinosaur("Smallie", 100, 50, 25));
            dinosaurs.Add(new Dinosaur("Mediumie", 200, 25, 50));
            dinosaurs.Add(new Dinosaur("Largeie", 300, 30, 75));
        }
        // member methods (CAN DO)

    }
}
