using System;
using wizninjasam.Models;

namespace wizninjasam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Writeline();
            Ninja ninja1 = new Ninja("Makenna the Ninja");
            Wizard wizard1 = new Wizard("Oscar the Wizard");
            Samurai samurai1 = new Samurai("Carlos the Samurai");
            Ninja ninja2 = new Ninja("Dany the Ninja");
            ninja1.stats();
            wizard1.stats();
            samurai1.stats();
            //Dany.stats();
            Console.WriteLine("****New Game Starting Now****");
            samurai1.Attack(ninja1);
            ninja1.Steal(wizard1);
            ninja1.Attack(wizard1);
            wizard1.Attack(ninja1);
            wizard1.Heal(ninja1);
            //Oscar.Attack(Carlos);
            //Oscar.Attack(Dany);
            //Makenna.Attack(Dany);
            //Carlos.Attack(Dany);
            //Oscar.Attack(Dany);
            //Makenna.Attack(Dany);
            //Oscar.Heal(Dany);
            samurai1.Meditate();
            ninja1.stats();
            wizard1.stats();
            samurai1.stats();
            //Dany.stats();


            
            //Console.WriteLine(Makenna.Dexterity);
        }
    }
}
