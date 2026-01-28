
Console.WriteLine("Exercice 25");


//1.Créer un tableau d’entiers contenant plusieurs notes.
//2. Copier uniquement les notes **valides** (entre 0 et 20 inclus) dans une `List<int>`.
//3. Pour chaque note valide, créer un tuple `(note, mention)` :

//   * ≥ 16 → `"Très bien"`
//   * ≥ 14 → `"Bien"`
//   * ≥ 12 → `"Assez bien"`
//   *sinon → `"Insuffisant"`
//4.Afficher les résultats.


int[] notes = { 18, 12, -3, 9, 21, 15 };

List<(int, string)> resultats = new List<(int, string)>();

for (int i = 0; i < notes.Length; i++)
{
    int note = notes[i];

    if (note < 0 || note > 20)
    {
        continue;
    }

    string mention;

    if (note >= 16)
    {
        mention = "Très bien";
    }
    else if (note >= 14)
    {
        mention = "Bien";
    }
    else if (note >= 12)
    {
        mention = "Assez bien";
    }
    else
    {
        mention = "Insuffisant";
    }

    resultats.Add((note, mention));
}

foreach ((int note, string mention) in resultats)
{
    Console.WriteLine("Note : " + note + " - Mention : " + mention);
}