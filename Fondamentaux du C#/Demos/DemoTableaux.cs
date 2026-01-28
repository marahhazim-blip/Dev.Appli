/*
    ------------------------------------------------------------
    1) Declaration d'un tableau (type reference)
    ------------------------------------------------------------
    Un tableau est une reference vers une zone memoire.
    A ce stade, aucune memoire n'est encore allouee.
*/

int[] nombres;
Console.WriteLine("Tableau 'nombres' declare (reference seulement).");
Console.WriteLine();

/*
    ------------------------------------------------------------
    2) Allocation de la memoire avec new
    ------------------------------------------------------------
    La taille indique le nombre d'elements du tableau.
*/

nombres = new int[3];
Console.WriteLine("Tableau 'nombres' alloue avec une taille de 3.");
Console.WriteLine("Taille recuperee avec .Length : " + nombres.Length);
Console.WriteLine("Valeurs par defaut : 0, 0, 0");
Console.WriteLine();

/*
    ------------------------------------------------------------
    3) Initialisation manuelle des valeurs
    ------------------------------------------------------------
    Les index commencent a 0 et vont jusqu'a Length - 1.
*/

nombres[0] = 10;
nombres[1] = 20;
nombres[2] = 30;

Console.WriteLine("Valeurs apres initialisation :");
Console.WriteLine(nombres[0]);
Console.WriteLine(nombres[1]);
Console.WriteLine(nombres[2]);
Console.WriteLine();

/*
    ------------------------------------------------------------
    4) Declaration + allocation en une seule instruction
    ------------------------------------------------------------
*/

string[] prenoms = new string[3];
Console.WriteLine("Taille de 'prenoms' avec .Length : " + prenoms.Length);

prenoms[0] = "Titi";
prenoms[1] = "Tata";
prenoms[2] = "Toto";

Console.WriteLine("Tableau 'prenoms' initialise :");
Console.WriteLine(prenoms[0]);
Console.WriteLine(prenoms[1]);
Console.WriteLine(prenoms[2]);
Console.WriteLine();

/*
    ------------------------------------------------------------
    5) Declaration + allocation + initialisation directe
    ------------------------------------------------------------
*/

float[] valeurs1 = new float[] { 2.5f, 0.3f, 5.9f };
float[] valeurs2 = { 2.5f, 0.3f, 5.9f };

Console.WriteLine("Taille de 'valeurs1' avec .Length : " + valeurs1.Length);

Console.WriteLine("Tableau 'valeurs1' :");
Console.WriteLine(valeurs1[0]);
Console.WriteLine(valeurs1[1]);
Console.WriteLine(valeurs1[2]);
Console.WriteLine();

/*
    ------------------------------------------------------------
     Copie de tableau = copie de reference
    ------------------------------------------------------------
*/

int[] t1 = { 2, 3, 4 };
int[] t2;

t2 = t1;

Console.WriteLine("Modification de t1[0] = 5");
t1[0] = 5;

Console.WriteLine("t1 : " + t1[0] + ", " + t1[1] + ", " + t1[2]);
Console.WriteLine("t2 : " + t2[0] + ", " + t2[1] + ", " + t2[2]);
Console.WriteLine();


/*
    ------------------------------------------------------------
     Copie de tableau avec CopyTo()
    ------------------------------------------------------------
    On obtient deux tableaux distincts.
*/

int[] source = { 2, 3, 4 };
int[] destination = new int[10];

source.CopyTo(destination, 0);

Console.WriteLine("Taille de 'source' : " + source.Length);
Console.WriteLine("Taille de 'destination' : " + destination.Length);

Console.WriteLine("Tableau source :");
Console.WriteLine(source[0] + ", " + source[1] + ", " + source[2]);

Console.WriteLine("Tableau destination (debut) :");
Console.WriteLine(destination[0] + ", " + destination[1] + ", " + destination[2] + ", " + destination[3]);
Console.WriteLine();

/*
    ------------------------------------------------------------
 Copie de tableau avec Clone()
    ------------------------------------------------------------
    Clone cree un nouveau tableau independant.
*/

int[] original = { 2, 3, 4 };
int[] copie = (int[])original.Clone();

original[0] = 100;

Console.WriteLine("Tableau original :");
Console.WriteLine(original[0] + ", " + original[1] + ", " + original[2]);

Console.WriteLine("Tableau copie :");
Console.WriteLine(copie[0] + ", " + copie[1] + ", " + copie[2]);
Console.WriteLine();

/*
    ------------------------------------------------------------
     Parcours d'un tableau (ajout)
    ------------------------------------------------------------
    - for : pratique si on a besoin de l'index
    - foreach : pratique pour lire chaque element simplement
*/

int[] parcours = { 10, 20, 30, 40 , 99 };

Console.WriteLine("Parcours avec for (avec index) :");
for (int i = 0; i < parcours.Length; i++)
{
    Console.WriteLine("Index " + i + " -> " + parcours[i]);
}

Console.WriteLine();

Console.WriteLine("Parcours avec foreach (lecture simple) :");
foreach (int valeur in parcours)
{
    Console.WriteLine(valeur);
}