using System;
using System.Collections.Generic;
using System.Text;

namespace POOCSharp.Classes
{
    internal class Voiture
    {

        // Attributs
        private string _model;
        private string _couleur;
        private int _reservoir;
        private int _autonomie;
        // Propriétés
        public string Model { get => _model; set => _model = value; }
        public string Couleur { get => _couleur; set => _couleur = value; }
        public int Reservoir { get => _reservoir; set => _reservoir = value; }
        public int Autonomie { get => _autonomie; set => _autonomie = value; }

        // Constructeurs
        public Voiture() { }
        public Voiture(string model, string couleur, int reservoir, int autonomie)
        {
            Model = model;
            Couleur = couleur;
            Reservoir = reservoir;
            Autonomie = autonomie;
        }

        public override string ToString()
        {
            return $"Je suis une voiture de model {Model} de couleur {Couleur} et re le modele {this._model} et resrerve + autonomie :  {_autonomie+_reservoir} ";
        }
    }

}
