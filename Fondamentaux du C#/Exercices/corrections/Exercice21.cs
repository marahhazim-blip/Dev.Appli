

Console.WriteLine("Exercice 21");


//1.Créer une `List<int>`.
//2. Demander à l’utilisateur de saisir 5 nombres.
//3. Ajouter uniquement les nombres **positifs** dans la liste.
//4. Afficher ensuite le contenu de la liste.

List<int> nombresPositifs = new List<int>(); // Créer une `List<int>`.

for (int i = 0; i < 5; i++)
{
    Console.WriteLine("Saisir un nombre :");
    string? saisie = Console.ReadLine();

    int n;
    bool ok = int.TryParse(saisie, out n);

    if (ok && n > 0) // Ajouter uniquement les nombres **positifs** dans la liste
    {
        nombresPositifs.Add(n);  // ajoute mon nombre a la liste
    }
}

Console.WriteLine("Nombres positifs saisis :");

foreach (int n in nombresPositifs)
{
    Console.WriteLine(n);
}