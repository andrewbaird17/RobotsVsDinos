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
        public int attackPower;
        public string randomWeapon;
        public Weapon weapon;
        public List<Weapon> weapons;

        // constructor (SPAWNER)
        public Robot(string name, int health, int powerLevel, int attackPower)
        {
            weapons = new List<Weapon>();
            this.name = name;
            this.health = health;
            this.powerLevel = powerLevel;
            randomWeapon = ChooseWeapon();
            this.attackPower = attackPower;
        }
        // member methods (CAN DO)

        public string ChooseWeapon()
        {
            List<string> weapons = new List<string>() { "Cannon", "Knife", "Sword", "Fist" };
            Random random = new Random();
            int index = random.Next(weapons.Count);

            string randomWeapon = weapons[index];
            // return random weapon 
            return randomWeapon;
        }
    }   
}

