using System;
using System.Collections.Generic;
using System.Text;

namespace ExoChaise.Classes
{
    internal class Chair
    {

        // Auto-property
        public int NbrPieds { get; set; }
        public string Materiau {  get; set; }
        public string Couleur { get; set; }


        // Constructeur(s)

        public Chair(int nbrPieds = 4, string materiau = "Bois", string couleur = "Blanche")
        {
            NbrPieds = nbrPieds;
            Materiau= materiau;
            Couleur = couleur;
            this.test = true;
        }


        // Methode(s)

        //public void Afficher()
        //{
        //    Console.WriteLine($"Je suis une Chaise, avec {this.NbrPieds} en {this.Materiau} et de couleur {this.Couleur}");
        //}

        // La methode ToString

        public override string ToString()
        {
                return $"Je suis une Chaise, avec {this.NbrPieds} en {this.Materiau} et de couleur {this.Couleur}";
            
        }
    }
}
