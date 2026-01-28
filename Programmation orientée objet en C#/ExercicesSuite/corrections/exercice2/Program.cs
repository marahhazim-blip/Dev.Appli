
using Exercice2.Classes;

Console.WriteLine("Exercice 2");


// Creation de plusieurs commandes 
Order order1 = new Order("toto",999);
Order order2 = new Order("tata",1);
Order order3 = new Order("tutu",600);
Order order4 = new Order("titi",50);
Order order5 = new Order("Phillipe",4);


// Annulation de certaines commandes
order2.Cancel();
order4.Cancel();

// Informations sur la globalite de mes commandes 
Order.InfosCommandes();

// BONUS utilisation de la classe OrderUtils

// Nom de client correct mais mal écrit 
string badUsername = "    tOTo     ";
string goodUserName = OrderUtils.NormalizeCustomerName(badUsername);
Console.WriteLine($"Nom de client mal ecrit : {badUsername} en version bien ecrit {goodUserName}");

// Les nom de client sont ils correct
// client qui s'apelle A
string name1 = "A";
Console.WriteLine($"Client qui a pour nom HA : {OrderUtils.IsValidCustomerName(name1)}");
// client qui s'apelle   TiTI  
string name2 = "  TiTI  ";
Console.WriteLine($"Client qui a pour nom   TiTI   : {OrderUtils.IsValidCustomerName(name2)}");