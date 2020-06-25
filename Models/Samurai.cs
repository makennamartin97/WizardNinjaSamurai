using System;
using System.Collections.Generic;

namespace wizninjasam.Models
{
    public class Samurai : Human
    {
        public int health = 200;
        public Samurai (string name) : base (name)
        {
            //int health = 200;
        }
        public override void Attack(Human target)
        {
            //base.Attack(target);
            if (target.Health <= 50)
            {
                int dmg = target.Health;
                target.applydamage(dmg);
                //target.Health = 0;
            }
            else{
                base.Attack(target);

            }
            
            //return target.Health;
        }
        public void Meditate(){
            int dmg = 200;
            oppositedamage(dmg);

            Console.WriteLine($"{Name} has recovered health!");
            
            //return Health;
        }
    }
}