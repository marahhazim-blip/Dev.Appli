// ------------------------------------------------------------
// Structures conditionnelles : if / else if / else
// ------------------------------------------------------------
// if exécute un bloc si la condition est vraie.
// Bonne pratique : utiliser des accolades, même pour une seule instruction.

//if (3 > 2)
//{
//    Console.WriteLine("3 est supérieur à 2 !!!");
//}

// ------------------------------------------------------------
// Exemple : chaîne de décisions (else if)
// ------------------------------------------------------------
//double note = 18;

//if (note >= 16)
//{
//    Console.WriteLine("Très bien");
//}
//else if (note >= 14)
//{
//    Console.WriteLine("Bien");
//}
//else if (note >= 12)
//{
//    Console.WriteLine("Assez bien");
//}
//else
//{
//    Console.WriteLine("Bof");
//}


// ------------------------------------------------------------
// Switch : choix parmi plusieurs cas
// ------------------------------------------------------------
Console.WriteLine("1- Dire bonjour");
Console.WriteLine("2- Dire au revoir");
Console.WriteLine("3- Dire bonne nuit");

int choix = 5;

// Switch "classique" (instructions)
// - break termine un case
// - default gère les valeurs non prévues
switch (choix)
{
    case 1:
        Console.WriteLine("Bonjour !!!");
        Console.WriteLine("plusieurs lignes");
        break;

    case 2:
        Console.WriteLine("Au revoir !!!");
        break;

    case 3:
        Console.WriteLine("Bonne nuit !!!");
        break;

    default:
        Console.WriteLine("Je n'ai pas compris votre choix");
        break;
}

// Switch expression (renvoie une valeur)
// Utile si l'objectif est de produire une valeur plutôt que d'exécuter plusieurs instructions.
string messageChoix = choix switch
{
    1 => "Bonjour !!!",
    2 => "Au revoir !!!",
    3 => "Bonne nuit !!!",
    _ => "Je n'ai pas compris votre choix"
};
Console.WriteLine(messageChoix);

// Lecture console + TryParse
// ------------------------------------------------------------
// Console.ReadLine() renvoie une string? (peut être null).
// int.Parse(...) lève une exception si le texte n'est pas un entier valide.
// int.TryParse(...) renvoie true/false et ne lève pas d'exception : c'est la méthode à privilégier.

Console.WriteLine("Entrez un nombre :");
string? saisie = Console.ReadLine();

int n;
bool conversionOk = int.TryParse(saisie, out n);

Console.WriteLine($"Conversion réussie : {conversionOk}");
Console.WriteLine($"Valeur obtenue : {n}");


// Exemple : négatif / nul / positif (if imbriqués)
// ------------------------------------------------------------
if (n < 0)
{
    Console.WriteLine("Ce nombre est négatif");
}
else
{
    if (n == 0)
    {
        Console.WriteLine("Ce nombre est nul");
    }
    else
    {
        Console.WriteLine("Ce nombre est positif");
    }
}


// Opérateur ternaire ?: (expression conditionnelle)
// ------------------------------------------------------------
// Structure : <condition> ? <valeur_si_vrai> : <valeur_si_faux>
// Utile pour produire une valeur courte, lisible, sans remplacer des if complexes.

int age = 14;
// bool majeur = age >= 18;
//string majeurStr = majeur ? "Il est majeur" : "Il n'est pas majeur";
string majeurStr = age >= 18 ? "Il est majeur" : "Il n'est pas majeur";
Console.WriteLine(majeurStr);

// Null coalescing operator ?? et ??=
// ------------------------------------------------------------
// ??  : si la valeur de gauche est null, on prend la valeur de droite
// ??= : si la variable est null, on lui affecte la valeur de droite

int? ageNullable = null;
int ageNonNull = ageNullable ?? 18;
Console.WriteLine(ageNonNull);

string? nom = null;
nom ??= "Inconnu";
Console.WriteLine(nom);

// Priorité des opérateurs logiques (&&, ||) et parenthèses
// ------------------------------------------------------------
// && a une priorité plus élevée que ||
// Donc : a || b && c est interprété comme : a || (b && c)

bool a = true;
bool b = false;
bool c = true;
bool d = false;

bool result1 = a || b && c && d;
bool result2 = (a || b) && (c && d);

Console.WriteLine($"result 1 : {result1}");
Console.WriteLine($"result 2 : {result2}");