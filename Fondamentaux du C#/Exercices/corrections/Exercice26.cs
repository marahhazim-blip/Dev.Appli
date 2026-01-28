//Écrire une fonction `AfficherTable` qui reçoit :

//*un nombre
//* une limite (par défaut à 10)

//La fonction **affiche la table de multiplication** du nombre.

//Dans le programme principal :

//*demander un nombre à l’utilisateur
//* appeler la fonction

void AfficherTable(int nombre, int limite = 10)
{
    for (int i = 1; i <= limite; i++)
    {
        Console.WriteLine(nombre + " x " + i + " = " + (nombre * i));
    }
}

Console.Write("Entrez un nombre : ");
string? saisie = Console.ReadLine();

if (int.TryParse(saisie, out int n))
{
    AfficherTable(n);
}
else
{
    Console.WriteLine("Entrée invalide.");
}