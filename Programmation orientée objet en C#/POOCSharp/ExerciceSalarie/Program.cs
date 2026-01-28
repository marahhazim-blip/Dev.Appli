// See https://aka.ms/new-console-template for more information
using ExerciceSalarie.Classes;

//Console.WriteLine("Hello, World!");


//Salarie s1 = new Salarie();
//Salarie s2 = new Salarie(3000,"RH","Employe","tata","AZERTY");

//s1.AfficherSalaire();
//s2.AfficherSalaire();


//Console.WriteLine($"J'ai {Salarie.cptSalarie} salarie dans mon programme");

////List<Salarie> salaries = new List<Salarie>();

////salaries.Add(s1);
////salaries.Add(s2);

//List<Salarie> salaries = new List<Salarie>(){ s1, s2 };

//salaries.Add(new Salarie(2500, "Tech", "Employe", "toto", "YTREZA"));

//Console.WriteLine($"Le total des salaires de mes {Salarie.cptSalarie} salarie est de {Salarie.totalSalaire} euros");

//Salarie.ResetCptSalarie();

//Console.WriteLine($"Le total des salaires (apres reset de cptSalarie) de mes {Salarie.cptSalarie} salarie est de {Salarie.totalSalaire} euros");


//IHM ihm = new IHM();
//ihm.Menu();

new IHM().Menu();
