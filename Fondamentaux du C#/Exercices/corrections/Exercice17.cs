// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Un tableau d’entiers est donné.

//Le programme doit déterminer si **deux valeurs consécutives identiques** existent dans le tableau.

//- Si oui, afficher un message indiquant qu’une répétition a été trouvée.
//- Sinon, afficher un message indiquant qu’aucune répétition n’existe.

int[] valeurs = { 3,  5, 2, 1 };
bool repetition = false;

for (int i = 0; i < valeurs.Length - 1; i++)
{
    if (valeurs[i] == valeurs[i + 1])
    {
        // j'ai deux valeurs consecutives
        repetition = true;
        break;
    }
    // si je ne suis jamais rentre dans mon if alors je n'ai pas de valeurs consecutives
}

if (repetition)
{
    Console.WriteLine("deux valeurs consécutives identiques trouvée");
}
else
{
    Console.WriteLine("Aucune valeurs consécutives identiques trouvée");
}