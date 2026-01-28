using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHeritage
{
    internal class Animal
    {

        public string Name { get; set; }
        public bool IsAlive { get; set; }
        public Animal(string name, bool isAlive)
        {
            Name = name;
            IsAlive = isAlive;
        }

        public virtual void Move()
        {
            Console.WriteLine("l'animal se déplace");
        }


        public override string ToString() {
            return "Je suis un animal";
        }
        
    }
}
