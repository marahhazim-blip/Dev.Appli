using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSalarieHeritage.Classes
{
    internal class Salarie
    {
        private int _salaire;
        public string Matricule { get; set; } = "000";
        public string Service { get; set; } = "Service par défaut";
        public string Categorie { get; set; } = "Catégorie par défaut";
        public string Nom { get; set; } = "Nom par défaut";
        public static int NombreSalaries { get; set; } = 0;
        public static int TotalSalaires { get; set; } = 0;

        public int Salaire
        {
            get => _salaire;
            set
            {
                TotalSalaires -= _salaire;
                _salaire = value;
                TotalSalaires += _salaire;
            }
        }

        public virtual decimal SalaireTotal => Salaire;

        public Salarie()
        {
            Salaire = 18000;
            NombreSalaries++;
        }

        public Salarie(int salaire, string matricule, string service, string categorie, string nom)
        {
            NombreSalaries++;
            Salaire = salaire;
            Matricule = matricule;
            Service = service;
            Categorie = categorie;
            Nom = nom;
        }

        public virtual void AfficherSalaire()
        {
            Console.WriteLine($"Le salaire de {Nom} est de {Salaire} euros");
        }

        public static void RemiseAZero()
        {
            NombreSalaries = 0;
            TotalSalaires = 0;
        }
    }
}
