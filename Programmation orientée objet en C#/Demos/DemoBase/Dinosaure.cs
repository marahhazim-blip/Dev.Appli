using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace POOCSharp.Classes
{
    internal class Dinosaure
    {

        private static int _nbrDeDinos = 0;
        public static int totalAge = 0;

        // Attributs
        public string nom;
        public int age;
        public string couleur;
        private string _espece;


        // Proprietes
        public string Espece { get => _espece; set => _espece = value; }


        // Méthodes Constructeur
        public Dinosaure(string nom, int age)
        {
            _nbrDeDinos++;
            this.nom = nom;
            this.age = age;
            this.couleur = "vert";
            this._espece = "raptor";
           // totalAge = totalAge + age;
            totalAge += age;
        }

        public Dinosaure() {
            _nbrDeDinos++;
            this.age = 555;
            this.nom = "tutu";
            this.couleur = "bleu";
            this._espece = "raptor";
        }


        // Méthodes
        public void SePresenter()
        {
            Console.WriteLine($"Bonjour je suis un dino, je m'apelle {this.nom} et j'ai {this.age} ans et je suis de l'espece {this._espece}.");
        }


        public string AfficherInfos()
        {
            return $"Bonjour je suis un dino, je m'apelle {this.nom} et j'ai {this.age} ans.";
        }

        // Methode static
        public static void AfficherNBDinos()
        {
            Console.WriteLine($"Nombre de dinos crees {_nbrDeDinos}");
        }

    }


}


