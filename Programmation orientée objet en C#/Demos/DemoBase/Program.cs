
using POOCSharp.Classes;

Console.WriteLine("POO CSharp !!!");


Dinosaure dino1 = new Dinosaure("toto", 564);
dino1.nom = "Guillaume";
Console.WriteLine(dino1.Espece);
dino1.Espece = "Diplo";
Console.WriteLine(dino1.Espece);
new Dinosaure();
Dinosaure.AfficherNBDinos();


//Console.WriteLine($"J'ai cree un premier dino qui s'apelle : {dino1.nom}");

//Dinosaure dino2 = new Dinosaure("tata",888);

//Console.WriteLine($"J'ai cree un second dino qui s'apelle : {dino2.nom} et qui a {dino2.age} ans.");

//dino1.SePresenter();
//dino2.SePresenter();
//Console.WriteLine(dino1.AfficherInfos());

//Dinosaure dino3 = new Dinosaure();

//dino3.SePresenter();

//Voiture v1 = new Voiture();
//Voiture v2 = new Voiture("Clio","blanche",300,15000);

//Console.WriteLine(v2.Reservoir);
//Console.WriteLine(v1.Reservoir);
//Console.WriteLine(v2.ToString());
//Console.WriteLine(v2);
//Console.WriteLine(v1);
//v1.Couleur = "Chartreuse";
//Console.WriteLine(v1);


