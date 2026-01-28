using System;
using System.Collections.Generic;
using System.Text;

namespace ExoChaise.Classes
{
    internal class Chaise
    {
        // Attribut(s)
        public int nbrPieds;
        public string materiau;
        public string couleur;


        // Constructeur(s)
        public Chaise()
        {
            this.nbrPieds = 4;
            this.materiau = "Bois";
            this.couleur = "Blanche";
        }

        public Chaise(int nbrPieds, string materiau, string couleur)
        {
            this.nbrPieds = nbrPieds;
            this.materiau = materiau;
            this.couleur = couleur;
        }


        // Methode(s)

        public void Afficher()
        {
            Console.WriteLine($"Je suis une Chaise, avec {this.nbrPieds} en {this.materiau} et de couleur {this.couleur}");
        }

    }
}
