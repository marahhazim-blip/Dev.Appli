// ------------------------------------------------------------
// Opérateurs arithmétiques (+, -, *, /, %)
// ------------------------------------------------------------
// Sur des entiers (int), la division / produit un résultat entier :
// la partie décimale est supprimée (division entière).

int originalResult = 5;
int result = originalResult + 2;
Console.WriteLine($"{originalResult} + 2 = {result}"); // 3

originalResult = result;

result = result - 1;
Console.WriteLine($"{originalResult} - 1 = {result}"); // 2
originalResult = result;

result = result * 2;
Console.WriteLine($"{originalResult} * 2 = {result}"); // 4
originalResult = result;

result = result / 2;
Console.WriteLine($"{originalResult} / 2 = {result}"); // 2
originalResult = result;

result = result + 8;
Console.WriteLine($"{originalResult} + 8 = {result}"); // 10
originalResult = result;

result = result % 7;
Console.WriteLine($"{originalResult} % 7 = {result}"); // 3

// Opérateurs unaires (+, -, ++, --, !)


// +x : identité (ne change pas la valeur)
// -x : négation (inverse le signe)
// ++ / -- : incrémente / décrémente d'une unité
// ! : négation logique (true -> false, false -> true)

int nombre = +1;
Console.WriteLine(nombre); // 1

nombre--;
Console.WriteLine(nombre); // 0

nombre++;
Console.WriteLine(nombre); // 1

nombre -= 2; // nombre = nombre - 2
nombre += 10; // nombre = nombre + 10

nombre = -nombre;
Console.WriteLine(nombre);

bool success = false;
Console.WriteLine(success);   // false
Console.WriteLine(!success);  // true

int x = 5;
x += 5;  // x = x + 5
x -= 3;  // x = x - 3

// Opérateurs relationnels et logiques

int value1 = 1;
int value2 = 2;
bool resultat;


resultat = value1 == value2;
Console.WriteLine(resultat); // false

resultat = value1 != value2;
Console.WriteLine(resultat); // true

resultat = value1 > value2;
Console.WriteLine(resultat); // false

resultat = (value1 == 1) && (value2 == 2);
Console.WriteLine(resultat); // true

resultat = (value1 == 1) || (value2 == 2);
Console.WriteLine(resultat); // true