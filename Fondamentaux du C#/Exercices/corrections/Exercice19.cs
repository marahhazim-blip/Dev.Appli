// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("Hello, World!");


//Un tableau contient une suite de nombres entiers.

//Le programme doit vérifier si le tableau respecte **la règle suivante** :

//> Chaque nombre doit être **strictement supérieur** au précédent.

//- Si la règle est respectée, afficher :
//  `"La suite est strictement croissante"`
//-Sinon, afficher:
//  `"La suite n'est pas strictement croissante"`

int[] suite = { 1, 2, 3,0, 7, 8, 9 };
bool suiteCroissante = true;


for (int i = 0; i < suite.Length - 1; i++)
{
    if(suite[i+1] <= suite[i])
    {
        // ma suite n'est pas croissante
        suiteCroissante = false;
        break;
    }
}

if (suiteCroissante)
{
    Console.WriteLine("La suite est strictement croissante");
}
else
{
    Console.WriteLine("La suite n'est pas strictement croissante");
}