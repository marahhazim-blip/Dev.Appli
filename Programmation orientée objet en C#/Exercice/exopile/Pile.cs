using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicePile
{
    internal class Pile<T>
    {
        //1. Créer une classe Pile<T> contenant un attribut T[] elements
        private List<T> _elements = new List<T>();

        //2. Ajouter une méthode permettant d'empiler un nouvel élément
        public void Empiler(T element)
        {
            _elements.Add(element);
        }

        //3. Ajouter une méthode permettant de dépiler le dernier élément empilé
        public T? Depiler()
        {
            if (_elements.Count == 0)
                return default; // si la liste est vide, on retourne le type par défaut
                                // on pourrait aussi lever une exception
                                //throw new Exception("La pile est vide!"); // utiliser InvalidOperationException

            //T dernierElement = _elements[_elements.Count - 1];
            T dernierElement = _elements[^1];
            _elements.RemoveAt(_elements.Count - 1);
            return dernierElement;
        }

        //4. Ajouter une méthode permettant de récupérer un élément par son index et ainsi de le retirer de la pile
        public T? Recuperer(int index)
        {
            //if(0 > index || index >= _elements.Count)
            if (!(0 <= index && index < _elements.Count))
                return default; // si la liste est vide, on retourne le type par défaut

            T element = _elements[index];
            _elements.RemoveAt(index);
            return element;
        }

        public override string ToString()
        {
            return "Pile : " + string.Join(", ", _elements);
        }
    }
}
