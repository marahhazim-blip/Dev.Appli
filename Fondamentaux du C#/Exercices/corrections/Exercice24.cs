
Console.WriteLine("Exercice 24");


//Un programme doit vérifier si une suite de nombres est **strictement décroissante**.

//1. L’utilisateur saisit des nombres jusqu’à entrer `0`.
//2. Les nombres sont stockés dans une `List<int>`.
//3. Le programme affiche si la suite est strictement décroissante ou non.


List<int> valeurs = new List<int>();

while (true)
{
    Console.WriteLine("Saisir un nombre (0 pour arrêter) :");
    int n = int.Parse(Console.ReadLine() ?? "0");

    if (n == 0)
    {
        break;
    }

    valeurs.Add(n);
}

bool strictementDecroissante = true;

for (int i = 0; i < valeurs.Count - 1; i++)
{
    if (valeurs[i + 1] >= valeurs[i])
    {
        strictementDecroissante = false;
        break;
    }
}

if (strictementDecroissante)
{
    Console.WriteLine("La suite est strictement décroissante");
}
else
{
    Console.WriteLine("La suite n'est pas strictement décroissante");
}