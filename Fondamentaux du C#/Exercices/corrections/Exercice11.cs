
Console.WriteLine("Exercice 11");


//Le programme choisit un nombre fixe (par exemple `7`).
//L’utilisateur doit deviner ce nombre.

//- Tant que l’utilisateur n’a pas trouvé le bon nombre, le programme redemande une saisie.
//- Quand le nombre est trouvé, afficher `Bravo, nombre trouvé !`.

int nombreSecret = 7;
Random rand = new Random();
nombreSecret = rand.Next(1,11);
int proposition;

do
{
    Console.WriteLine("Devinez le nombre entre 1 et 10 :");
    string? saisie = Console.ReadLine();

    while(!int.TryParse(saisie, out proposition))
    {
        Console.WriteLine("Saisie invalide. Entrez un entier :");
        saisie = Console.ReadLine();
    }

    if(proposition != nombreSecret)
    {
        Console.WriteLine("Ce n'est pas le bon nombre.");
    }
    

} while (proposition != nombreSecret);



Console.WriteLine("Bravo, nombre trouvé !");