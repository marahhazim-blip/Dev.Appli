using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGenerique
{
    internal class Personne
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Personne(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"{Name} - {Age} ans";
        }
    }
}
