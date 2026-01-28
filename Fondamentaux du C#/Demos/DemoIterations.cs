/*
    1) while : boucle conditionnelle
       - La condition est verifiee AVANT d'entrer dans la boucle
       - Donc la boucle peut s'executer 0 fois si la condition est fausse des le depart
*/


Console.WriteLine("Entrez un entier entre 1 et 5 :");

int valeur;
string? saisie = Console.ReadLine();

while (!int.TryParse(saisie, out valeur) || valeur < 1 || valeur > 5)
{
    Console.WriteLine("Saisie invalide. Entrez un entier entre 1 et 5 :");
    saisie = Console.ReadLine();
}

Console.WriteLine("OK, valeur acceptee : " + valeur);
Console.WriteLine(); // saut de ligne

Console.WriteLine(" do...while : mini-menu (tapez 'q' pour quitter)");
string? choix;

do
{
    Console.WriteLine("Menu: (a) Afficher heure | (b) Afficher date | (q) Quitter");
    choix = Console.ReadLine();

    if (choix == "a")
    {
        Console.WriteLine("Heure: " + DateTime.Now.ToString("HH:mm:ss"));
    }
    else if (choix == "b")
    {
        Console.WriteLine("Date : " + DateTime.Now.ToString("yyyy-MM-dd"));
    }
    else if (choix != "q")
    {
        Console.WriteLine("Choix inconnu.");
    }

} while (choix != "q");

Console.WriteLine("Sortie du menu (do...while).");
Console.WriteLine();

/*
     for : boucle d'iteration avec variable d'iteration
       - Nombre d'iterations souvent connu a l'avance
       - La variable (compteur / i) est declaree dans le for
*/

Console.WriteLine("for : compteur de 1 a 5");
for (int compteur = 1; compteur <= 5; compteur++)
{
    Console.WriteLine("Compteur = " + compteur);
}

Console.WriteLine(" for : parcourir un tableau (jours de la semaine)");
string[] joursSemTableau = { "Lundi", "Mardi", "Mercredi", "Jeudi", "Vendredi", "Samedi", "Dimanche" };

for (int i = 0; i < joursSemTableau.Length; i++)
{
    Console.WriteLine("joursSemTableau[" + i + "] = " + joursSemTableau[i]);
}
Console.WriteLine();

Console.WriteLine(" foreach : parcourir une chaine (alphabet) caractere par caractere");
string alphabet = "abcdefghijklmnopqrstuvwxyz";

foreach (char lettre in alphabet)
{
    Console.Write(lettre + " ");
}

/*
    8) break / continue (complements au support)
       - break : sortir immediatement de la boucle
       - continue : passer a l'iteration suivante (on saute la fin du bloc)
*/

Console.WriteLine("break : recherche d'un element et sortie immediate");
List<string> prenoms = new List<string> { "Alice", "Bob", "Charlie", "Diana", "Eve" };
string cible = "Charlie";
bool trouve = false;

for (int i = 0; i < prenoms.Count; i++)
{
    if (prenoms[i] == cible)
    {
        Console.WriteLine("Trouve '" + cible + "' a l'index " + i);
        trouve = true;
        break;
    }
}

if (!trouve)
{
    Console.WriteLine("'" + cible + "' non trouve");
}


Console.WriteLine(" continue : ignorer certaines iterations (ne pas afficher les voyelles)");

string texte = "formation";
foreach (char c in texte)
{
    char lower = char.ToLowerInvariant(c);
    bool estVoyelle = lower == 'a' || lower == 'e' || lower == 'i' || lower == 'o' || lower == 'u' || lower == 'y';



    if (estVoyelle)
    {
        continue;
    }

    Console.Write(c + " ");
}