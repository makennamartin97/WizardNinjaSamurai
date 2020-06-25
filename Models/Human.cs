using System;
using System.Collections.Generic;

namespace wizninjasam.Models
{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        protected int health;
     
        public int Health
        {
            get { return health; }
            //set { health = Health; }
        }
     
        public Human(string name)
        {
            Name = name;
            Strength = 3;
            Intelligence = 3;
            Dexterity = 3;
            health = 100;
        }
     
        public Human(string name, int str, int intel, int dex, int hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            health = hp;
        }
        public void stats(){
            Console.WriteLine($"Here are {Name}'s stats:");
            Console.WriteLine($"{Strength} Strength");
            Console.WriteLine($"{Intelligence} Intelligence");
            Console.WriteLine($"{Dexterity} Dexterity");
            Console.WriteLine($"{health} Health");


        }
     
    // Build Attack method
        public virtual void Attack(Human target)
        {
            //if (target.GetType() == typeof(Human))
            //{
            //    var enemy = target as Human;
            //    enemy.health -= Strength * 5;
            //}
            //else
            //{
            //    Console.WriteLine("FAIL");
            //}

            int dmg = Strength * 3;
            target.applydamage(dmg);
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            Console.WriteLine($"{target.Name} now has {target.health} health, and {Name} has {health} health.");
            //return target.health;
        }
        public void applydamage(int dmg){
            health -= dmg;
        }
        public void oppositedamage(int dmg){
            health += dmg;
        }

    
    }
}
