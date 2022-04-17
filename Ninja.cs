using System;
using System.Collections.Generic;

namespace wizard_ninja_samurai
{
    public class Ninja: Human 
    {
        public Ninja(string name) : base (name, 100, 100, 175, 100){}
    //This is where the Attack Method will go
                public void DealDamage(Human target)
        {
            int amount = Strength * -5;
            Console.WriteLine($"{this.Name} strikes {target.Name}, taking {amount} damage!!");
            target.ChangeHealth(amount);
            Console.WriteLine($"{target.Name}'s current health: {target.health}");
        }

    //This is where the Steal Method will go
}
}
