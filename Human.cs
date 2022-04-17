using System;

namespace wizard_ninja_samurai
{
        public class Human
    {
        //These are all the things/attributes to descibe the human
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;
        public int health {get{return Health;}}

        //This is a constructor allowing to set custum values
        public Human(string name, int strength, int intelligence, int dexterity, int health)
        {
            this.Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            Health = health;
        }

        //This is a method that allows the human to be attacked
        public int Attack(Human target)
        {
            int AttackValue = Strength *5;
            target.Health -= AttackValue;
            return target.health;
        }

        public void showStats()
        {
            Console.WriteLine($"Name: {this.Name}");
            Console.WriteLine($"Strength: {this.Strength}");
            Console.WriteLine($"Intelligence: {this.Intelligence}");
            Console.WriteLine($"Dexterity: {this.Dexterity}");
            Console.WriteLine($"Health: {this.Health}");
        }

        public  virtual void DealDamage(Human target, int amount)
        {
            Console.WriteLine($"{this.Name} attacked {target.Name}, taking {amount} damage!!");
            target.Health -= amount;
            Console.WriteLine($"{target.Name}'s health: {target.health}");
        }

            public void ChangeHealth(int amount)
            {
                this.Health += amount;
            }
        
    }
}
