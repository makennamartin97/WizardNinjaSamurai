using System;
using System.Collections.Generic;

namespace wizninjasam.Models
{
    public class Ninja : Human
    {
        public Ninja (string name) : base (name)
        {
            int Dexterity = 175;
        }
        public override void Attack(Human target)
        {
            Random rand = new Random();
            int critical = rand.Next(0,21);
            //int dmg = 0;
            Console.WriteLine($"{target.Name} has {target.Health} health.");
            if (critical == 20)
            {
                int dmg = (target.Dexterity * 5)+10;
                target.applydamage(dmg);
                Console.WriteLine($"Ouch! Critical hit! {target.Name} takes {dmg} damage!");
            }
            else if(critical >4){
                int dmg = target.Dexterity * 5;
                target.applydamage(dmg);
                Console.WriteLine($"Hit! {target.Name} takes {dmg} damage.");
            }
            else{
                Console.WriteLine($"Oops! {Name} missed!");
            }
            //target.applydamage(dmg);
            //Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            //Console.WriteLine($"{target.Name} now has {target.Health} health!");
            //return target.Health;
        }
        public void Steal(Human target){
            int dmg = 5;
            target.applydamage(dmg);
            health += 5;
            Console.WriteLine($"{Name} has stolen 5 health from {target.Name}!");
            Console.WriteLine($"{target.Name} now has {target.Health} health, {Name} now has {health} health.");
            //return target.Health;

        }
    }
}