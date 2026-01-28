
Console.WriteLine("Demo List");

// ------------------------------------------------------------
// LISTES (List<T>)
// ------------------------------------------------------------
// Une List est un conteneur dynamique :
// - on ne fixe pas la taille à l'avance
// - on peut ajouter / supprimer des éléments facilement

List<string> mesChaines = new List<string>(){"chaine1","chaine2","chaine2", "chaine3","chaine4","chaine5"};

// Count permet de connaître le nombre d'éléments
Console.WriteLine("Nombre d'éléments dans la liste : " + mesChaines.Count);

// Suppression de la première occurrence de "chaine2"
mesChaines.Remove("chaine2");

// Count permet de connaître le nombre d'éléments
Console.WriteLine("Nombre d'éléments dans la liste apres supression : " + mesChaines.Count);

// Suppression de l'élément à l'index 0
mesChaines.RemoveAt(0);

// Count permet de connaître le nombre d'éléments
Console.WriteLine("Nombre d'éléments dans la liste apres supression avec RemoveAt : " + mesChaines.Count);

// Ajout d'un nouvel élément
mesChaines.Add("chaine6");

// Count permet de connaître le nombre d'éléments
Console.WriteLine("Nombre d'éléments dans la liste apres ajout d'un nouvelle element (Add) : " + mesChaines.Count);

// Parcours de la liste avec foreach
Console.WriteLine("Contenu de la liste :");
foreach (string item in mesChaines)
{
    Console.WriteLine(item);
}

// Suppression de tous les éléments
mesChaines.Clear();
Console.WriteLine("Liste vidée. Count = " + mesChaines.Count);


// ------------------------------------------------------------
// TUPLES
// ------------------------------------------------------------
// Le tuple permet de regrouper plusieurs valeurs de types différents
// Les données sont non modifiables (immutables)


// Packing (affectation directe)
(double, int, string) t1 = (4.5, 3, "test");

// Accès aux éléments via ItemX
Console.WriteLine("Tuple t1 :");
Console.WriteLine(t1.Item1);
Console.WriteLine(t1.Item2);
Console.WriteLine(t1.Item3);

// Autre notation avec ValueTuple
ValueTuple<double, int, string> t2 = (2.1, 10, "exemple");

Console.WriteLine("Tuple t2 :");
Console.WriteLine(t2.Item1);
Console.WriteLine(t2.Item2);
Console.WriteLine(t2.Item3);

// Unpacking : décomposition du tuple dans plusieurs variables
(double monDouble, int monInt, string monString) = t1;

Console.WriteLine("Après unpacking :");
Console.WriteLine(monDouble);
Console.WriteLine(monInt);
Console.WriteLine(monString);

// Unpacking avec var
var (d2, i2, s2) = t2;
Console.WriteLine(d2);
Console.WriteLine(i2);
Console.WriteLine(s2);

// Renommage des éléments du tuple
(double MonDouble, int MonInt, string MonString) t3 = t1;

Console.WriteLine("Tuple renommé :");
Console.WriteLine(t3.MonDouble);
Console.WriteLine(t3.MonInt);
Console.WriteLine(t3.MonString);