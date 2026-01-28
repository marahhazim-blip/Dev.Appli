
Console.WriteLine("Demo Base C Sharp !!!!");

// Commentaires sur une ligne
/*
 Commentaires
 sur plusieurs lignes
 en C#
*/

/*
             -------------------------------------------------
             DEMONSTRATION : LES VARIABLES EN C#
             -------------------------------------------------
             Une variable permet de stocker une valeur en mémoire
             afin de la réutiliser plus tard dans le programme.
            */

// Une variable est définie par :
// - un type
// - un nom
// Elle peut être déclarée sans valeur initiale.

// -------------------------------------------------
// DECLARATION D'UNE VARIABLE
// -------------------------------------------------
// Syntaxe générale :
// <type> <nom>;


// int : entier signé sur 32 bits
// En C#, int est un alias de System.Int32
int age;

// long : entier signé sur 64 bits
// Alias de System.Int64
long indice;

// float : nombre réel sur 32 bits
float distance;

// double : nombre réel sur 64 bits
double monnaie;

// bool : valeur booléenne (true ou false)
bool estVrai;

// char : caractère Unicode (UTF-16)
char lettre;

// string : chaîne de caractères
// Ce n'est PAS un type primitif
// C'est un type référence (System.String)
string prenom;

// -------------------------------------------------
// DECLARATION + INITIALISATION
// -------------------------------------------------
// Syntaxe :
// <type> <nom> = <valeur>;

int jour = 5;

// AFFECTATION D'UNE VALEUR

age = 35;

// Le séparateur '_' est autorisé pour améliorer la lisibilité
indice = 100_000_000;

// Le suffixe 'f' est obligatoire pour les float
distance = 12.74f;

// Les nombres décimaux sont en double par défaut
monnaie = 15.5;

estVrai = false;
lettre = 'a';
prenom = "toto";

// AFFICHAGE DANS LA CONSOLE

Console.WriteLine(distance);
Console.WriteLine(prenom);
Console.WriteLine("Age : " + age);