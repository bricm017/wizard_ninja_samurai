using System;
using System.Collections.Generic;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Wizard w1 = new Wizard("Merlin");

            Ninja n1 = new Ninja("Roxas");

            Samurai s1 = new Samurai("Korra");

            w1.showStats();
            n1.showStats();
            s1.showStats();

            w1.DealDamage();
        }
    }
}
