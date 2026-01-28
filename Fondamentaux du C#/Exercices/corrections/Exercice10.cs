Console.WriteLine("Exercice 10");

//Demander à l’utilisateur de saisir un entier strictement positif.

// Poser une question a l'utilisateur
Console.WriteLine("saisir un entier strictement positif : ");

// Recuperation de la saisi utilisateur
string? saisie = Console.ReadLine();

// transformation de string a int
int value;
//bool reussi = int.TryParse(saisie, out value);

////Tant que l’utilisateur ne saisit pas un entier valide (> 0), redemander la saisie.

//while (!reussi || value <=0)
//{
//    Console.WriteLine("Valeur invalide, saisir un entier strictement positif :");
//    saisie = Console.ReadLine();
//    reussi = int.TryParse(saisie, out value);

//}

while (!int.TryParse(saisie, out value) || value <= 0)
{
    Console.WriteLine("Valeur invalide, saisir un entier strictement positif :");
    saisie = Console.ReadLine();

}


//Une fois la valeur valide saisie, afficher tous les nombres de `1` jusqu’à ce nombre, **un par ligne**, à l’aide d’une boucle `while`.
int compteur = 1;

while(compteur <= value)
{
    Console.WriteLine(compteur);
    compteur++;
}