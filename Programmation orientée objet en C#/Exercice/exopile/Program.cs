
using ExercicePile;

Pile<string> pileString = new Pile<string>();

pileString.Empiler("Bonjour");
pileString.Empiler("Test");
pileString.Empiler("ABC");

Console.WriteLine(pileString);

Console.WriteLine(pileString.Depiler());
Console.WriteLine(pileString.Depiler());

Console.WriteLine(pileString);

pileString.Empiler("ABC1");
pileString.Empiler("ABC2");

Console.WriteLine(pileString);

Console.WriteLine("1 -> " + pileString.Recuperer(1));
Console.WriteLine("2 -> " + pileString.Recuperer(2));

Console.WriteLine(pileString);

Pile<Personne> pilePersonne = new Pile<Personne>();


pilePersonne.Empiler(new Personne());
pilePersonne.Empiler(new Personne());