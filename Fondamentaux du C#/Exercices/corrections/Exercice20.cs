
Console.WriteLine("Exercice 20");

//Écrire un programme qui :

//1.Demande à l’utilisateur de saisir des mots (chaînes de caractères).
//2. Tant que l’utilisateur ne saisit pas `"stop"`, le mot est ajouté dans une `List<string>`.
//3. À la fin :

//   *afficher le nombre total de mots saisis
//   * afficher tous les mots un par un

List<string> mots = new List<string>(); // creation d'une liste de string vide

while (true)  // on rentre dans la boucle car true mais on as break present dans la boucle
{
    Console.WriteLine("Saisir un mot (stop pour arrêter) :");
    string saisie = Console.ReadLine() ?? "";

    if (saisie == "stop") // Tant que l’utilisateur ne saisit pas `"stop"`, le mot est ajouté dans une `List<string>`.
    {
        break;
    }

    mots.Add(saisie); // le mot est ajouté dans une `List<string>`
}

Console.WriteLine("Nombre de mots saisis : " + mots.Count); // afficher le nombre total de mots saisis

foreach (string mot in mots) // afficher tous les mots un par un
{
    Console.WriteLine(mot);
}