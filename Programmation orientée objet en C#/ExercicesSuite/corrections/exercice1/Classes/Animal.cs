using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1.Classes
{
    internal class Animal
    {
        // Attributs
        private string _name;
        private string _species;
        private int _energy;

        // Propriete
        public string Name { get => _name; set => _name = value; }
        public string Species { get => _species; set => _species = value; }
        public int Energy { get => _energy; set => _energy = value; }

        // Constructeur
        public Animal(string name, string species, int energy)
        {
            this._name = name;
            this._species = species;
            this._energy = energy;
        }

        // Methodes 
        public void Eat(int amount)
        {
            //this._energy = this._energy + amount;
            this._energy += amount;
        }

        public void Play(int amount) { 
            this._energy -= amount;
        }

        public string Describe()
        {
            return $"{this._name} , espece : {this._species} , energie : {this._energy}";
        }
    }
}
