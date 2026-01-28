using System;
using System.Collections.Generic;
using System.Text;

namespace ExoSalarie.Classes
{
    internal class Salarie
    {
        public string Matricule { get; set; } = "000";
        public string Service { get; set; } = "Service par défaut";
        public string Nom { get; set; } = "Nom par défaut";
        public string Categorie { get; set; } = "Categorie par défaut";
        public double Salaire { get; set; } = 2000;

        public Salarie() { }
        public Salarie(string matricule, string service, string nom, string categorie, double salaire)
        {
            Matricule = matricule;
            Service = service;
            Nom = nom;
            Categorie = categorie;
            Salaire = salaire;
        }

        public override string ToString()
        {
            return $"Je suis un salarie , mon nom : {Nom}, mon matricule : {Matricule}, mon service {Service}, ma categorie {Categorie} et mon salaire {Salaire}";
        }

    }
}
