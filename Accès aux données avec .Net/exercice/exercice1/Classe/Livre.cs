using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1.Classe
{
    internal class Livre
    {


        public int Id { get; set; }
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int AnneePublication { get; set; }
        public string Isbn { get; set; }

        public Livre(string titre,string auteur,int anneePublication,string isbn) { 
            Titre = titre;
            Auteur = auteur;
            AnneePublication = anneePublication;
            Isbn = isbn;
        }
        public Livre(int id,string titre, string auteur, int anneePublication, string isbn)
        {
            Id = id;
            Titre = titre;
            Auteur = auteur;
            AnneePublication = anneePublication;
            Isbn = isbn;
        }

        public override string ToString()
        {
            return $"Livre : titre {Titre}, auteur {Auteur}, annee de publication : {AnneePublication} , isbn : {Isbn} , id : {Id}";
        }
    }
}
