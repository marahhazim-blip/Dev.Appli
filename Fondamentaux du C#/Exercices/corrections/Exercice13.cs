
Console.WriteLine("Exercice 13");


//Demander à l’utilisateur de saisir un mot.

Console.WriteLine("saisir un mot : ");
//string? mot = Console.ReadLine();
string mot = Console.ReadLine() ?? "";

//Parcourir chaque caractère du mot et compter le nombre de voyelles (`a, e, i, o, u, y`).
int compteurVoyelle = 0;

foreach(char c in mot)
{
    if(c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'y')
    {
        compteurVoyelle++;
    }
}

//À la fin, afficher le nombre de voyelles trouvées.

Console.WriteLine($"Nombre de voyelles : {compteurVoyelle}");
