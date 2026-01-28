


//Écrire une fonction `DecrireNombre` qui reçoit un nombre entier et **retourne une chaîne** indiquant si le nombre est :

//*négatif
//* nul
//* positif

//Dans le programme principal :

//*demander un nombre à l’utilisateur
//* afficher le résultat retourné par la fonction


string DecrireNombre(int nombre)
{
    if (nombre < 0)
    {
        return "Le nombre est négatif";
    }
    else if (nombre == 0)
    {
        return "Le nombre est nul";
    }
    else
    {
        return "Le nombre est positif";
    }
}

Console.Write("Entrez un nombre : ");
string? saisie = Console.ReadLine();

if (int.TryParse(saisie, out int n))
{
    string resultat = DecrireNombre(n);
    Console.WriteLine(resultat);
}
else
{
    Console.WriteLine("Entrée invalide.");
}