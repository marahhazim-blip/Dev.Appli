


Console.WriteLine("Exercice 22");


//Un programme doit enregistrer des températures saisies par l’utilisateur.

//Règles :

//1.L’utilisateur saisit des températures une par une.
//2. La saisie s’arrête quand il entre `-999`.
//3. Les températures valides sont entre `-50` et `50`.
//4. Les valeurs valides sont stockées dans une `List<int>`.
//5. Les valeurs invalides sont comptées (mais non stockées).

//À la fin, afficher :

//*le nombre de valeurs valides
//* le nombre de valeurs invalides
//* la température minimale et maximale valides

List<int> temperatures = new List<int>();
int invalides = 0;

while (true)
{
    Console.WriteLine("Saisir une température (-999 pour arrêter) :");
    int t = int.Parse(Console.ReadLine() ?? "0");

    if (t == -999)
    {
        break;
    }

    if (t < -50 || t > 50)
    {
        invalides++;
    }
    else
    {
        temperatures.Add(t);
    }
}

if (temperatures.Count > 0)  // permet de s'assurer qu'on as au minimum une valeur valide dans notre liste de temperature
{
    int min = temperatures[0];
    int max = temperatures[0];

    foreach (int t in temperatures)
    {
        if (t < min) min = t; // si la temperature parcourue est inferieur a mon min alors cette temperateure devient mon min
        if (t > max) max = t; // si la temperature parcourue est superieur a mon max alors cette temperature devient mon max
    }

    Console.WriteLine("Valeurs valides : " + temperatures.Count);
    Console.WriteLine("Valeurs invalides : " + invalides);
    Console.WriteLine("Min : " + min);
    Console.WriteLine("Max : " + max);
    // autre solution pour obtenir le min et le max de ma liste de int : 
    Console.WriteLine("Min : " + temperatures.Min());
    Console.WriteLine("Max : " + temperatures.Max());
   
}
else
{
    Console.WriteLine("Aucune valeur valide.");
}

