using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOOSuite.Heritage
{
    internal class Person
    {
        public string Nom {  get; set; }
        public string Prenom { get; set; }

        public Person(string Nom, string Prenom)
        {
            this.Nom = Nom;
            this.Prenom = Prenom;
        }

        public virtual string Presentation()
        {
            return $"Bonjour je suis une personne et je m'apelle {this.Nom} {this.Prenom}";
        }
    }
}
