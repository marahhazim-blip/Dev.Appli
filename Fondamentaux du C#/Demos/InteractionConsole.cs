
// ------------------------------------------------------------
// Interaction console : affichage (WriteLine / Write)
// ------------------------------------------------------------
// Console.WriteLine(...) : écrit un texte puis ajoute un saut de ligne.
// Console.Write(...)     : écrit un texte sans ajouter de saut de ligne.

Console.WriteLine("Bonjour");
Console.WriteLine("à tous !!");
Console.WriteLine();
Console.WriteLine("##################");
Console.WriteLine();

Console.Write("Bonjour");
Console.Write(" à tous !!");
Console.WriteLine(); // retour à la ligne après deux Write


// Interaction console : lecture clavier

Console.WriteLine("Quel est votre nom ? ");
string? nomUtilisateur = Console.ReadLine();

Console.Write("Bonjour ");
Console.WriteLine(nomUtilisateur);


Console.WriteLine("Quel est votre prenom ? ");
string? prenomUtilisateur = Console.ReadLine();

Console.Write("Bonjour ");
Console.WriteLine(prenomUtilisateur);

Console.WriteLine("Quel est votre age ?");
int ageUtilisateur = int.Parse(Console.ReadLine()!);


Console.Write("Vous avez ");
Console.Write(ageUtilisateur);
Console.WriteLine(" ans.");