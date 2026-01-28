using System;
using System.Collections.Generic;
using System.Text;

namespace DemoPOOSuite.Heritage
{
    internal class Formateur : Person
    {

        public string Cour {  get; set; }
        public Formateur(string Nom, string Prenom, string cour) : base(Nom, Prenom)
        {
            Cour = cour;
        }

        public override string Presentation()
        {
            return base.Presentation().ToUpperInvariant() + $" mon metier et formateur je fais cours de {Cour}";
        }

        public override string ToString() {
            return $"Je suis un formateur qui a fini avec vous {Nom} {Prenom}";
           // return Presentation();
        }
    }
}
