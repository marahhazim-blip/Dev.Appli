using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOOSuite
{
    internal class MaClasse
    {

        // Attributs
        // visibilite type nom
        private string monAttribut;
        // static
        private static int nbrMaClasse = 0;

        // Constructeur
        // visibilite => public NomDeLaClasse (parametres si j'en ai besoin => type nomDuParametre)
        public MaClasse(string monAttribut)
        {
            this.monAttribut = monAttribut; // le mot cle this fais reference a MaClasse donc ici a monAttribut
            nbrMaClasse++;
        }

        // Methode
        // visibilite type de retour nom de la methode (parametres si j'en ai besoin => type nomDuParametre)
        public string RenvoyerMonAttribut()
        {
            return monAttribut;
        }

        // Propriete
        // public type de retour Nom {}
       // public string MonAttribut { get { return monAttribut; } set { monAttribut = value; } }
        public string MonAttribut { get => monAttribut;  set => monAttribut = value;  }

        // Methodes 
        public static string Compteur()
        {
            return $"Le compteur est à : {nbrMaClasse}";    
        }



    }
}
