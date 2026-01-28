// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Demander à l’utilisateur :

//-un premier entier `a`
//- un opérateur parmi `+`, `-`, `*`, `/`
//- un second entier `b`

//Afficher le résultat.
//Contraintes :

//-utiliser `TryParse` pour `a` et `b` (si invalide → message d’erreur)
//- si l’opérateur est inconnu → `Operateur invalide`
//- si division par 0 → `Division impossible`


// Recuperation des entier et de l'operateur
Console.WriteLine("Saisir un entier :");
string? saisieA = Console.ReadLine();

Console.WriteLine("Saisir un operateur + - * / :");
string? op = Console.ReadLine();

Console.WriteLine("Saisir second entier :");
string? saisieB = Console.ReadLine();

int a;
int b;
bool okA = int.TryParse(saisieA, out a);
bool okB = int.TryParse(saisieB, out b);

if(!okA || !okB)
{
    // ici cela signifie que A et B son invalide (le parse a echoue)
    Console.WriteLine("Nombre invalide");
}
else
{
    // ici j'ai 2 nombre valide et mon operateur
    switch (op)
    {
        case "+":
            Console.WriteLine($"Resultat : {a+b}");
            break;
        case "-":
            Console.WriteLine($"Resultat : {a - b}");
            break;
        case "*":
            Console.WriteLine($"Resultat : {a * b}");
            break;
        case "/":
            if(b == 0)
            {
                Console.WriteLine("Division impossible");
            }
            else
            {
                Console.WriteLine($"Resultat : {a / b}");
            }
            break;
        default:
            Console.WriteLine("Operateur invalide");
            break;

    }
}