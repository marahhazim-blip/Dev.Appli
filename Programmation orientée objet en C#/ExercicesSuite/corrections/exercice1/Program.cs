using Exercice1.Classes;

Console.WriteLine("Exercice 1");

Enclos enclos = new Enclos("Enclos Nord", 1); // creation d'un enclos

Animal luna = new Animal("Luna", "Chat", 80); // creation de l'animal luna
Animal rex = new Animal("Rex", "Chien", 50); // creation de l'animal Rex
Animal milo = new Animal("Milo", "Lapin", 30); // creation de l'animal Milo

// ajout des animaux cree a notre enclos
bool succeAjoutLuna = enclos.AddAnimal(luna); // ajout de luna a l'enclos
bool succeAjoutRex = enclos.AddAnimal(rex);  // ajout de rex a l'enclos
bool succeAjoutMilo = enclos.AddAnimal(milo); // ajout de milo a l'enclos

Console.WriteLine($"Ajout de Luna : {succeAjoutLuna}");
Console.WriteLine($"Ajout de rex : {succeAjoutRex}");
Console.WriteLine($"Ajout de Milo : {succeAjoutMilo}");

luna.Play(40);// luna doit perdre 40 d'energie
rex.Eat(60); // rex doit gagner 60 d'energie

Console.WriteLine("Verification de l'etat de l'enclos :");
enclos.PrintStatus();

// creation d'un premier rapport 
VetoReport report1 = new VetoReport();
report1.SetAnimalName("Luna");
report1.SetNotes("Fatigue après jeu");
report1.SetSeverity(2);

// creation d'un second rapport 
VetoReport report2 = new VetoReport();
report2.SetAnimalName("Rex");
report2.SetNotes("Très bonne forme");
report2.SetSeverity(1);

// Affichage des rapport cree
Console.WriteLine("Rapports:");
Console.WriteLine("Rapport 1:");
report1.Print();
Console.WriteLine("Rapport 2:");
report2.Print();
