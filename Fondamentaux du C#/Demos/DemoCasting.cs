// Obtenir le type d'une valeur avec GetType()

int entier_int = 10;
double reel = 12.5;
string texte_str = "Bonjour";

Console.WriteLine(entier_int.GetType()); // System.Int32
Console.WriteLine(reel.GetType());   // System.Double
Console.WriteLine(texte_str.GetType());  // System.String

// Casting de type : conversions implicites et explicites

// Un cast (conversion) permet de transformer une valeur d'un type vers un autre.
//
// On distingue :
// - conversion implicite : automatique (sans perte d'information)
// - conversion explicite : nécessite un cast (peut entraîner une perte)

// 1) Conversions implicites (sûres)

// int -> long : conversion implicite (plage de long plus grande)
int entier = 42;
long entierLong = entier;

Console.WriteLine(entier);       // 42
Console.WriteLine(entierLong);   // 42

// int -> double : conversion implicite
double entierEnDouble = entier;
Console.WriteLine(entierEnDouble); // 42

// float -> double : conversion implicite
float distance = 12.5f;
double distanceDouble = distance;
Console.WriteLine(distanceDouble); // 12.5


// 2) Conversions explicites (cast obligatoire)

// long -> int : conversion explicite (risque de dépassement)
long grandNombre = 3_000_000_000;
int grandNombreEnInt = (int)grandNombre;

// Le résultat peut être incohérent si la valeur dépasse la plage de int
Console.WriteLine(grandNombre);
Console.WriteLine(grandNombreEnInt);


// long -> int : conversion explicite (risque de dépassement)
long grandNombre2 = 30_000_000;
int grandNombreEnInt2 = (int)grandNombre2;

// Le résultat peut être incohérent si la valeur dépasse la plage de int
Console.WriteLine(grandNombre2);
Console.WriteLine(grandNombreEnInt2);

// double -> int : conversion explicite (perte de la partie décimale)
double prix = 19.99;
int prixEntier = (int)prix;

Console.WriteLine(prix);       // 19.99
Console.WriteLine(prixEntier); // 19

// 4) Opérateur "is" : test de type

string prenom = "Alice";
Console.WriteLine(prenom is string); // true

int age = 30;
Console.WriteLine(age is int);       // true
Console.WriteLine(age is long);      // false