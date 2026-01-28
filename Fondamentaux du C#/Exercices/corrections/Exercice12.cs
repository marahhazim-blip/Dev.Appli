
Console.WriteLine("Exercice 12");


//Demander à l’utilisateur de saisir un entier.
//Afficher la table de multiplication de cet entier de `1` à `10` à l’aide d’une boucle `for`.

Console.WriteLine("Entrez un entier :");
string? saisie = Console.ReadLine();

int nombre;

int.TryParse(saisie, out nombre);

Console.WriteLine("Entrez la fin de la table :");
string? saisie2 = Console.ReadLine();

int nombre2;

int.TryParse(saisie2, out nombre2);




for (int i  = 1;i <= nombre2; i++)
{
    Console.WriteLine($"{nombre} x {i} = {nombre * i}");
}