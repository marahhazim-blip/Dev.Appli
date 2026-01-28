using System;
using System.Collections.Generic;
using System.Text;

namespace Exo02Commande.Classes
{
    internal class Client
    {
        public int Id { get; set; }
        public string Prenom { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string CodePostal { get; set; }
        public string Ville { get; set; }
        public string Telephone { get; set; }
        public List<Commande> Commandes { get; set; } = new List<Commande>();

        

        //  Constructeur sans ID lors de la création d'un client
        public Client(string prenom, string nom, string adresse, string codePostal, string ville, string telephone)
        {
            Prenom = prenom;
            Nom = nom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Telephone = telephone;
        }

        // Constructeur avec ID lors de la lecture en base de données
        public Client(int id, string prenom, string nom, string adresse, string codePostal, string ville, string telephone) : this(prenom, nom, adresse, codePostal, ville, telephone)
        {
            Id = id;
        }


        public override string ToString()
        {
            return $"ID: {Id} Identité: {Prenom} {Nom} Telephone: {Telephone} Adresse: {Adresse} {CodePostal} {Ville}";
        }
    }
}
