// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Demander à l’utilisateur :

//-un identifiant(`login`)(peut être vide)
//- un mot de passe (`password`) (peut être vide)
//- un code admin (`adminCode`) (peut être vide)

//Règles :

//-Si `login` est null ou vide, le remplacer par `"Invite"` en utilisant `??=` **ou** une logique équivalente.
//- L’utilisateur est **connecté** si :

//  -(`login` n’est pas `"Invite"` ET `password` vaut `"1234"`) **OU**
//  - (`adminCode` vaut `"ADMIN"`)

//- Afficher `Acces autorise` ou `Acces refuse` en utilisant **l’opérateur ternaire** `?:`.
//-Attention à la priorité `&&` / `||` : parenthèses obligatoires.


Console.WriteLine("Login :");
string? login = Console.ReadLine();

Console.WriteLine("Password :");
string? password = Console.ReadLine();

Console.WriteLine("AdminCode :");
string? adminCode = Console.ReadLine();

login ??= "";
password ??= "";
adminCode ??= "";

if (login == "")
{
    login = "Invite";
}


//  -(`login` n’est pas `"Invite"` ET `password` vaut `"1234"`) **OU**
//  - (`adminCode` vaut `"ADMIN"`)
bool acces = ((login != "Invite") && (password == "1234")) || (adminCode == "ADMIN");

string message = acces ? "Acces autorise" : "Acces refuse";
Console.WriteLine(message);

Console.WriteLine(((login != "Invite") && (password == "1234")) || (adminCode == "ADMIN") ? "Acces autorise" : "Acces refuse");