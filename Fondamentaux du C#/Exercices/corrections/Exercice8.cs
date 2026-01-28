// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Demander un entier `n` (via `TryParse`).
//Si la saisie est invalide → `Entier invalide`.

//Sinon :

//1.Afficher s’il est `negatif`, `nul` ou `positif` (avec `if` imbriqués comme dans la démo).
//2. Puis afficher si `pair` ou `impair` (avec un `if / else` séparé).
//3. Enfin, afficher `Dans [-10;10]` si `n` est dans l’intervalle, sinon `Hors [-10;10]`.

Console.Write("Entrez un entier: ");
string? saisie = Console.ReadLine();

int n;
bool ok = int.TryParse(saisie, out n);

if (!ok)
{
    Console.WriteLine("Entier invalide");
}
else
{
    if (n < 0)
    {
        Console.WriteLine("negatif");
    }
    else
    {
        if (n == 0)
        {
            Console.WriteLine("nul");
        }
        else
        {
            Console.WriteLine("positif");
        }

    }

    if (n % 2 == 0)
    {
        Console.WriteLine("pair");
    }
    else {
        Console.WriteLine("impair");
    }

    if (n >= -10 && n <= 10)
    {
        Console.WriteLine("Dans [-10;10]");
    }
    else
    {
        Console.WriteLine("Hors [-10;10]");
    }
}