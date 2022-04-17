using System;
using System.Collections.Generic;

namespace wizard_ninja_samurai
{
    public class Wizard: Human 
    {
        public Wizard(string name) : base (name, 50, 25, 100, 100){}
    //This is where the Attack Method will go with the 
        public void DealDamage(Human target)
        {
            int amount = Strength * -5;
            Console.WriteLine($"{this.Name} strikes {target.Name}, taking {amount} damage!!");
            target.ChangeHealth(amount);
            Console.WriteLine($"{target.Name}'s current health: {target.health}");
        }


    //This is where the Heal Method will go
    }
}
