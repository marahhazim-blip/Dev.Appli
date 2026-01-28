// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Un tableau de taille 5 doit contenir des âges.

//Le programme doit :

//1.Demander à l’utilisateur de saisir 5 âges.
//2. Refuser toute valeur négative ou supérieure à 120.
//3. Stocker uniquement les valeurs valides dans le tableau.
//4. Afficher à la fin :

//   -le tableau complet
//   - le nombre d’âges invalides saisis


int[] ages = new int[5];
int compteurInvalid = 0;


for  (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine("Saisir un age : ");
    string? saisie = Console.ReadLine();
    int age;
    bool ok = int.TryParse(saisie, out age);
    if (!ok || age < 0 || age > 120)
    {
        Console.WriteLine("Age invalide. Saisie ignorée valeur par défaut 0");
        ages[i] = 0;
        compteurInvalid++;
    }
    else
    {
        ages[i] = age;
    }

    
}

Console.WriteLine($"Nombres de notes invalides saisies : {compteurInvalid}");
Console.WriteLine("Mon tableaux d'ages :");
foreach(int age in ages)
{
    Console.WriteLine(age); 
}