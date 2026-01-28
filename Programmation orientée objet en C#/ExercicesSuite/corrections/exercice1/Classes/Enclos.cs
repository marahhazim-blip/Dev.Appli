using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1.Classes
{
    internal class Enclos
    {
        // Atributs
        private int _capacity;
        private List<Animal> _animals;
        private string _name;

        // Proprietes
        public int Capacity { get => _capacity; set => _capacity = value; }
        public string Name { get => _name;  set => _name = value;  }
        public List<Animal> Animals { get => _animals;  set => _animals = value; }


        // Constructeur 
        public Enclos(string name, int capacity)
        {
            _name = name; 
            _capacity = capacity;
            _animals = new List<Animal>();
        }

        public bool AddAnimal(Animal animal)
        {
            if(this._capacity > this._animals.Count)
            {
                this._animals.Add(animal);
                return true;
            }
            return false;
        }

        public void RemoveAnimal(string name) 
        {
            foreach (Animal animal in _animals)
            {
                if(animal.Name == name)
                {
                    _animals.Remove(animal);
                }
            }
        }

        public List <Animal> GetAnimals() { 
            return new List<Animal>(_animals); 
        }

        public void PrintStatus() {
            Console.WriteLine("####### Debut Infos #######");
            Console.WriteLine($"Information sur l'enclos {this._name} de capacité {this._capacity} :");
            Console.WriteLine("Liste des Animaux dans cette enclos :");
            foreach(Animal animal in _animals)
            {
                Console.WriteLine(animal.Describe());
            }
            Console.WriteLine("####### Fin Infos #######");
        }




    }
}
