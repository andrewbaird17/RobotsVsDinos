using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinosaursVsRobots
{
    class Robot
    {
        // member variables (HAS A)
        public string name;
        public int health;
        public int powerLevel;
        public string weapon;
        public int attackPower;

        // constructor (SPAWNER)
        public Robot(string name, int health, int powerLevel, int attackPower)
        {
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            weapon = "";
            this.attackPower = attackPower;
        }
        // member methods (CAN DO)
    }   
}

