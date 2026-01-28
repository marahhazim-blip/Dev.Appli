using System;
using System.Collections.Generic;
using System.Text;

namespace DemoGenerique
{
    internal class Repository<T>
    {

        private List<T> _elements;

        public Repository()
        {
            _elements = new List<T>();
        }


        public void Ajouter(T element)
        {
            _elements.Add(element);
            Console.WriteLine($"j'ai rajoute {element} a la liste l'element recu");
        }

        public void AfficherTout()
        {
            foreach (T element in _elements)
            {
                Console.WriteLine(element);
            }
                    
        }
    }
}
