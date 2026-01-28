using System;
using System.Collections.Generic;
using System.Text;

namespace DemoHeritage
{
    internal class Mammifere : Animal
    {

        public string Genre { get; set; }
        public Mammifere(string name, bool isAlive, string genre) : base(name, isAlive)
        {
            Genre = genre;
        }

        public void Respirer()
        {
            Console.WriteLine("Le mammifere respire");
        }

        public override void Move()
        {
            Console.WriteLine("Je suis un mamiffere et je me deplace");
        }
    }
}
