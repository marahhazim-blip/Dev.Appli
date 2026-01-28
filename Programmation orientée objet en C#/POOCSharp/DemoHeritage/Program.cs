// See https://aka.ms/new-console-template for more information
using DemoHeritage;

Console.WriteLine("Hello, World!");


Animal animal = new Animal("toto",true);
Mammifere mammifere = new Mammifere("Tata", true, "femelle");

animal.Move();
mammifere.Respirer();
mammifere.Move();

Console.WriteLine(animal);
Console.WriteLine(animal.ToString());

