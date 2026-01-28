using System;
using System.Collections.Generic;
using System.Text;

namespace DemoADO.Classes
{
    internal class Auteur
    {

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Email { get; set; }
        public List<Livre> Livres { get; set; } = new List<Livre>();

        public Auteur() { }

        public Auteur(string nom, string email)
        {
            Nom = nom;
            Email = email;
        }

        public Auteur(int id, string nom, string email) : this(nom, email)
        {
            Id = id;
        }

        public override string ToString()
        {
             return $"Auteur #{Id} | {Nom} | {Email} | Livres: {Livres.Count}";
        }
           
    }
}
