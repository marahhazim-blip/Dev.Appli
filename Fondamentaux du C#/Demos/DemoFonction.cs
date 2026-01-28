
Console.WriteLine("Demos Fonctions");


// Fonctions locales (déclarations)

//void AffichageBienvenue(string prenom , string langage )
//{

//    Console.WriteLine("Bonjour " + prenom + " !");
//    Console.WriteLine("---------");
//    Console.WriteLine("\tBienvenue dans le monde merveilleux du " + langage);
//    Console.WriteLine("---------");
//}


//AffichageBienvenue("Guillaume", "C#");
//Console.WriteLine();
//AffichageBienvenue("Antoine", "Javascript");
////Console.WriteLine();
//AffichageBienvenue("Toto", "Python");


double Additionner(double nombreUn, double nombreDeux)
{
    double sommeDesNombres = nombreUn + nombreDeux;
    return sommeDesNombres;
}

//Console.WriteLine("2) Fonction avec valeur de retour (return)");
//double resultat = Additionner(2, 4);
//Console.WriteLine("Additionner(2, 4) = " + resultat);

//double resultatComplexe = Additionner(2, 4) * 4;
//Console.WriteLine("Additionner(2, 4) * 4 = " + resultatComplexe);
//Console.WriteLine();

//double AdditionnerParDefaut(double nombreUn = 1, double nombreDeux = 2)
//{
//    return nombreUn + nombreDeux;
//}

//Console.WriteLine("3) Paramètres par défaut");
//Console.WriteLine("AdditionnerParDefaut(2, 4) = " + AdditionnerParDefaut(2, 4));
//Console.WriteLine("AdditionnerParDefaut() = " + AdditionnerParDefaut());
//Console.WriteLine();

//void ModifierValeur(int nombre)
//{
//    nombre = 100;
//}

//void ModifierValeurRef(ref int nombre)
//{
//    nombre = 100;
//}

//void InitialiserValeur(out int nombre)
//{
//    nombre = 42;
//}

//void AfficherValeur(in int nombre)
//{
//    Console.WriteLine(nombre);
//}

//Console.WriteLine("4) Passage des paramètres : valeur vs référence");
//int x = 10;

//Console.WriteLine("Avant ModifierValeur(x) : x = " + x);
//ModifierValeur(x);
//Console.WriteLine("Après ModifierValeur(x) : x = " + x);

//Console.WriteLine();
//Console.WriteLine("Avant ModifierValeurRef(ref x) : x = " + x);
//ModifierValeurRef(ref x);
//Console.WriteLine("Après ModifierValeurRef(ref x) : x = " + x);

//Console.WriteLine();
//int y;
//InitialiserValeur(out y);
//Console.WriteLine("Après InitialiserValeur(out y) : y = " + y);

//Console.WriteLine();
//int z = 5;
//Console.WriteLine("AfficherValeur(in z) :");
//AfficherValeur(in z);
//Console.WriteLine();



//string Concatenateur(int numero, params string[] chaines)
//{
//    string chaineFinale = numero + " - ";

//    foreach (var chaine in chaines)
//    {
//        chaineFinale += chaine;
//    }

//    return chaineFinale;
//}

//Console.WriteLine("5) params : nombre variable d'arguments");
//string[] mesChaines = { "Bonjour", "Tout", "Le Monde" };
//Console.WriteLine(Concatenateur(1, mesChaines));
//Console.WriteLine(Concatenateur(2, "Bonjour", "Tout", "Le Monde"));
//Console.WriteLine();

Console.WriteLine("6) Interaction console + fonction");
Console.Write("Entrez un premier nombre : ");
string? saisieA = Console.ReadLine();
Console.Write("Entrez un second nombre : ");
string? saisieB = Console.ReadLine();

if (double.TryParse(saisieA, out double a) && double.TryParse(saisieB, out double b))
{
    Console.WriteLine("Résultat : " + Additionner(a, b));
}
else
{
    Console.WriteLine("Entrée invalide : veuillez saisir des nombres.");
}