using System;
using System.Collections.Generic;
using System.Text;

namespace DemoADO.Classes
{
    internal class Livre
    {

        public int Id { get; set; }
        public string Titre { get; set; }
        public int AnneePublication { get; set; }
        public string Isbn { get; set; }
        public int AuteurId { get; set; }

        public Livre() { }

        public Livre(string titre, int anneePublication, string isbn, int auteurId)
        {
            Titre = titre;
            AnneePublication = anneePublication;
            Isbn = isbn;
            AuteurId = auteurId;
        }

        public Livre(int id, string titre, int anneePublication, string isbn, int auteurId)
        {
            Titre = titre;
            AnneePublication = anneePublication;
            Isbn = isbn;
            AuteurId = auteurId;
            Id = id;
        }

        public override string ToString()
        {
            return $"Livre #{Id} | {Titre} | {AnneePublication} | ISBN: {Isbn} | AuteurId: {AuteurId}"; 
        }
    }
}
