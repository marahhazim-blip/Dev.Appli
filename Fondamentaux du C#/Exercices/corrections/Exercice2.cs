// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercice 2 :");


//Écrire un programme qui :
//1.Demande à l’utilisateur de saisir deux nombres entiers.
//2. Stocke ces valeurs dans deux variables.
Console.WriteLine("Saisir le premier nombre :");
int nbr1 = int.Parse(Console.ReadLine()!);

//Console.WriteLine("Saisir le second nombre :");
//int nbr2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Saisir le second nombre :");
double nbr2 = double.Parse(Console.ReadLine()!);


//3. Calcule la somme de ces deux nombres.

double somme = nbr1 + nbr2;

//4. Affiche le résultat dans la console.

Console.WriteLine($"La somme de {nbr1} et {nbr2} est égal à {somme}");