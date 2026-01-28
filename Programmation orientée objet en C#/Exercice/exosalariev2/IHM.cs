using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciceSalarie.Classes
{
    internal class IHM
    {

        private List<Salarie> salaries = new List<Salarie>(); // stocker mes salarie

        public void AjouterSalarie() // ajouter un salarie a mon stockage
        {
            Console.WriteLine("Saisir le nom du salarie : ");
            string nom = Console.ReadLine() ?? "toto";
            Console.WriteLine("Saisir le service du salarie : ");
            string service = Console.ReadLine() ?? "toto";
            Console.WriteLine("Saisir le matricule du salarie : ");
            string matricule = Console.ReadLine() ?? "toto";
            Console.WriteLine("Saisir le categorie du salarie : ");
            string categorie = Console.ReadLine() ?? "toto";
            Console.WriteLine("Saisir le salaire du salarie : ");
            string salaireSTR = Console.ReadLine() ?? "toto";
            double salaire = double.Parse(salaireSTR);
            Salarie salarie = new Salarie(salaire,service,categorie,nom,matricule);
            this.salaries.Add(salarie);
        }

        public void AfficherTousLesSalaries()
        {
            if (salaries.Count > 0)
            {
                foreach (Salarie s in this.salaries)
                {
                    s.AfficherSalaire();
                }
            }
            else
            {
                Console.WriteLine("Aucun salarie present pour l'instant.");
            }
              
        }

        public void DisplayMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine("1- Ajouter un salarie");
            Console.WriteLine("2- Afficher tous les salarie");
            Console.WriteLine("0- Quitter");
            Console.WriteLine("Votre choix :");
        }

        public void Menu()
        {
            while (true) {
                this.DisplayMenu();
                string choix = Console.ReadLine() ?? "";

                switch (choix)
                {
                    case "1":
                        this.AjouterSalarie();
                        break;
                    case "2":
                        this.AfficherTousLesSalaries();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("choix pas compris");
                        break;
                }
                }

            }

    }
}
