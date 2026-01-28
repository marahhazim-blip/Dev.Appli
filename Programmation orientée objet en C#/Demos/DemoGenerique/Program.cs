// See https://aka.ms/new-console-template for more information
using DemoGenerique;

Console.WriteLine("Hello, World!");


Repository<Personne> personnes = new Repository<Personne>();

personnes.Ajouter(new Personne("toto", 25));
personnes.Ajouter(new Personne("tata", 42));

personnes.AfficherTout();

Repository<Produit> prod = new Repository<Produit>();

prod.Ajouter(new Produit("Xbox", 600));

prod.AfficherTout();

Repository<int> count = new Repository<int>();