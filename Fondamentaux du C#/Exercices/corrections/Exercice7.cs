// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Demander une note entière entre 0 et 20.

//- Si la saisie est invalide ou hors intervalle → `Note invalide`
//- Sinon produire un message **avec une switch expression** :

//Barème(différent de la démo) :

//-18..20 → `Excellent`
//- 15..17 → `Tres bien`
//- 12..14 → `Bien`
//- 10..11 → `Passable`
//- 0..9 → `Insuffisant`

//Afficher le message.

Console.Write("Entrez une note sur 20 : ");
string? saisie = Console.ReadLine();
Console.WriteLine($"Vous avez saisie {saisie}");

int note;
bool ok = int.TryParse( saisie, out note );

if (!ok || note < 0 || note > 20 ) // inferieur a 0  ou superieur 20 ou ce n'est pas un nombre (alors ok est a false)
{
    // ici la note est invalide
    Console.WriteLine("Note invalide");
}
else
{
    // ici la note est valide
    string message = note switch
    {
        >= 18 and <= 20 => "Excellent", // and pour donner une valeur max ( donc entre 18 et 20) mais pas obligatoire ici
        >= 15 and <= 17 => "Tres Bien",
        >= 12 => "Bien",
        >= 10 => "Passable",
        _ => "Insuffissant"
    };

    Console.WriteLine(message);

}