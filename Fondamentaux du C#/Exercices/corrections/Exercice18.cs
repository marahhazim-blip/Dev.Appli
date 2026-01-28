// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");



//Un tableau contient des notes sur 20.

//Le programme doit :

//1.Parcourir le tableau.
//2.Appliquer les règles suivantes :

//   -une note inférieure à 10 devient 10
//   - une note supérieure à 20 devient 20

//3. Afficher le tableau après modification.

int[] notes = { 5, 12, 19, 25, 9, 20, 0 };

Console.WriteLine(" Notes avant modif :");
foreach (int note in notes)
{
    Console.WriteLine($"note : {note}");
}

for (int i  = 0; i < notes.Length; i++)
{
    if(notes[i] < 10)
    {
        notes[i] = 10;
    }else if(notes[i] > 20) { 
        notes[i] = 20; 
    }

}

Console.WriteLine(" Notes apres modif :");
foreach(int note in notes)
{
    Console.WriteLine($"note : {note}");
}