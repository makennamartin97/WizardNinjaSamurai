using System;
using System.Collections.Generic;

namespace wizninjasam.Models
{
    public class Wizard : Human
    {
        public Wizard (string name) : base (name)
        {
            Intelligence = 25;
            health = 50;
        }
        public override void Attack(Human target)
        {
            Console.WriteLine($"{Name} has {health} health and {target.Name} has {target.Health} health.");
            int dmg = Intelligence * 5;
            target.applydamage(dmg);
            //target.Intelligence -= dmg;
            Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
            //health += dmg;
            oppositedamage(dmg);
            Console.WriteLine($"{Name} now has {health} health and {target.Name} now has {target.Health} health and {target.Intelligence} intelligence.");
            //return target.Health;

        }
        public void Heal(Human target)
        {
            int dmg = Intelligence * 10;
            target.oppositedamage(dmg);
            //target.Health += cure;
            Console.WriteLine($"{Name} has healed {target.Name} and now they have {target.Health} health!");
            //return (int)Health;
        }
    }
}