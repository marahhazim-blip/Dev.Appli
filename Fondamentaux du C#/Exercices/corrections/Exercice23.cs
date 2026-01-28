
Console.WriteLine("Exercice 23");


//On dispose d’un tableau d’entiers représentant des scores.

//1. Copier les scores **pairs** dans une `List<int>`.
//2. Copier les scores **impairs** dans une autre `List<int>`.
//3. Afficher les deux listes séparément.

int[] scores = { 12, 7, 9, 20, 3, 18 };

List<int> pairs = new List<int>();
List<int> impairs = new List<int>();

for (int i = 0; i < scores.Length; i++)
{
    if (scores[i] % 2 == 0)
    {
        pairs.Add(scores[i]);
    }
    else
    {
        impairs.Add(scores[i]);
    }
}

Console.WriteLine("Scores pairs :");
foreach (int p in pairs)
{
    Console.WriteLine(p);
}

Console.WriteLine("Scores impairs :");
foreach (int i in impairs)
{
    Console.WriteLine(i);
}