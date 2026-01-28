

//Écrire une fonction `CompterPairs` qui reçoit une liste d’entiers et **retourne le nombre de valeurs paires**.

//Dans le programme principal :

//*créer une liste de nombres
//* afficher le nombre de valeurs paires

int CompterPairs(List<int> nombres)
{
    int compteur = 0;

    foreach (int n in nombres)
    {
        if (n % 2 == 0)
        {
            compteur++;
        }
    }

    return compteur;
}

List<int> valeurs = new List<int> { 1, 4, 7, 10, 12, 3 };

int nbPairs = CompterPairs(valeurs);
Console.WriteLine("Nombre de valeurs paires : " + nbPairs);
