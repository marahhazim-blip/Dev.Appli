// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercice 4");


//1.Demande à l’utilisateur la longueur d’un rectangle.

Console.WriteLine("Saisir la longueur d’un rectangle : ");
double longueur = double.Parse(Console.ReadLine()!);

//2. Demande ensuite sa largeur.

Console.WriteLine("Saisir la largeur d’un rectangle : ");
double largeur = double.Parse(Console.ReadLine()!);


//3. Calcule le périmètre du rectangle.

double perimetre = 2 * (longueur + largeur);

//4. Calcule l’aire du rectangle.

double aire = longueur * largeur;

//5. Affiche les deux résultats.


Console.WriteLine($"L'aire du rectangle est : {aire}");
Console.WriteLine($"Le périmetre du rectangle est : {perimetre}");

//Formules :

//*Périmètre = 2 × (longueur + largeur)
//* Aire = longueur × largeur