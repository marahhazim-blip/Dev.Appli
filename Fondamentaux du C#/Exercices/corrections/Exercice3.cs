// See https://aka.ms/new-console-template for more information
Console.WriteLine("Exercice 3");



//1.Demande à l’utilisateur une température en degrés Celsius.
Console.Write("Saisir la température en Celcius : ");
//2. Stocke la valeur dans une variable.
double celcius = double.Parse(Console.ReadLine()!);


//3. Convertit cette température en degrés Fahrenheit selon la formule :
//Fahrenheit = (Celsius × 9 / 5) +32
double fahrenheit = (celcius * 9 / 5) + 32;


//4.Affiche la température convertie.
Console.WriteLine("Température en Fahrenheit : " + fahrenheit);
