// See https://aka.ms/new-console-template for more information
using static System.Runtime.InteropServices.JavaScript.JSType;

Console.WriteLine("EXERCICE 15");


//Un programme dispose d’un tableau d’entiers représentant des valeurs mesurées par un capteur.

//- Certaines valeurs peuvent être aberrantes (négatives).
//- Une valeur aberrante doit être ignorée.

//Écrire un programme qui :

//1.Parcourt le tableau.
//2.Ignore les valeurs négatives.
//3. Calcule et affiche :

//   -le nombre de valeurs valides
//   - la somme des valeurs valides
//   - la moyenne des valeurs valides (si possible)

int[] mesures = { 12, -3, 7, 0, 25, -1, 9 };

//int[] mesures = { -3, -1 };
int compteurValid = 0;
int somme = 0;


// avec un for classique
//for(int i = 0; i < mesures.Length; i++)
//{
//    if(mesures[i] < 0)
//    {
//        // valeur du capteur en dessous de 0 donc négatif => a ignore
//        continue;
//    }
//    compteurValid++;
//    //somme = somme + mesures[i];
//    somme += mesures[i];
//    Console.WriteLine($"Valeur correct : {mesures[i]}");
//}

// avec un foreach

foreach(int mesure in mesures)
{
    if(mesure >= 0)
    {
        Console.WriteLine($"Valeur correct : {mesure}");
        somme += mesure;
        compteurValid++;
    }

}


Console.WriteLine($"Nombre de valeur correct : {compteurValid}");
Console.WriteLine($"Sommes des valeurs correct : {somme}");

if(compteurValid > 0)
{
    Console.WriteLine($"Moyennes des valeurs correct : {(double)somme / compteurValid}");
}
else
{
    Console.WriteLine("Je n'ai pas de mesures positif donc pas de moyennes");
}
