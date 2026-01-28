// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Linq.Expressions;

Console.WriteLine("Exercice 5");


// Recuperation des entree

//Demander à l’utilisateur :
double standard;
double express;
//1.un poids(en kg) saisi au clavier
//2. un mode de livraison (`standard` ou `express`)

Console.WriteLine("Entrez le poids en kg");
//string? saisiePoids = Console.ReadLine();

//double poids;
//poids = double.Parse(saisiePoids);

//double poids = double.Parse(Console.ReadLine()!);

string? saisiePoids = Console.ReadLine();

double poids;
bool poidsOk = double.TryParse(saisiePoids,out poids);


//Console.WriteLine($"Le poids est correct et il est  de : {poids}");
// je recupere le mode de livraison
Console.WriteLine("Votre mode de livraison (standard/express)");
string? mode = Console.ReadLine();

string message;

// Fin de la recuperation
// J'ai quand j'arrive ici un poids et un mode de livraison
// et j'ai une vraible message

// je passe a la partie algo

if (!poidsOk || poids <= 0)
{
    // si j'arrive entre ces accolades c'est que mon poids est invalide
    //Console.WriteLine();
    message = "Point invalide";
}
else
{
    // si j'arrive entre ces accolades c'est que mon poids est valide
    //Console.WriteLine($"Le poids est correct et il est  de : {poids}");
    //// je recupere le mode de livraison
    //Console.WriteLine("Votre mode de livraison (standard/express)");
    //string? mode = Console.ReadLine();

    //-si le poids est **≤ 1** : standard = 4.99, express = 7.99
    if (poids <= 1)
    {
        standard = 4.99;
        express = 7.99;
    }
    else if (poids <= 5) //- si le poids est **≤ 5** : standard = 6.99, express = 10.99
    {
        standard = 6.99;
        express = 10.99;
    }
    else //- sinon : standard = 9.99, express = 14.99
    {
        standard = 9.99;
        express = 14.99;
    }

    if(mode == "standard")
    {
        // Console.WriteLine($"Prix {standard}");
        message = $"Prix {standard}";
    }
    else if (mode == "express")
    {
        //Console.WriteLine($"Prix {express}");
        message = $"Prix {express}";
    }
    else
    {
        //Console.WriteLine("Mode Invalide");
        message = "Mode Invalide";
    }

}


// REsponse / sortie de mon algo je donne la reponse a mon utilisateur
Console.WriteLine(message);

//Règles :




//Si la saisie du poids est invalide, afficher `Poids invalide`.
//Si le mode est invalide, afficher `Mode invalide`.
//Sinon afficher `Prix: X`.


