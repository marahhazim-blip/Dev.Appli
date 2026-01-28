using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSalarie.Classes
{
    internal class Salarie
    {
        
        // Auto-property
        public string Matricule { get; set; } = "000";
        public string Service { get; set; } = "Service par défaut";
        public string Categorie { get; set; } = "Categorie par défaut";
        public string Nom { get; set; } = "Nom par défaut";
        public double Salaire { get; set; } = 2000;

        // champs statique
        public static int cptSalarie = 0;
        public static double totalSalaire = 0;


        // Constructeurs
        public Salarie(double salaire, string service, string categorie, string nom, string matricule)
        {
            Matricule = matricule;
            Service = service;
            Categorie = categorie;
            Nom = nom;
            Salaire = salaire;
            cptSalarie++;
            totalSalaire += salaire;
        }

        public Salarie() {
            cptSalarie++;
            totalSalaire += Salaire;
        }

        // Methodes

        public void AfficherSalaire()
        {
            Console.WriteLine($"Je m'apelle {this.Nom} et j'ai un salaire de {this.Salaire} euros.");
        }

        public static void ResetCptSalarie()
        {
            cptSalarie = 0;
        }

    }
}
