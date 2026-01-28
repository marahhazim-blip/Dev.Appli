
using ExoSalarie.Classes;

Console.WriteLine("Exercice Salarie");

List<Salarie> salaries = new List<Salarie>() {
    new Salarie(),
    new Salarie("001","Compta","Toto","Technicien",1700.3), 
    new Salarie("002","RH","Tata","Admin",2000.6), 
    new Salarie("003","R et D","Tutu","Admin",1856.7), 
    new Salarie("004","Logistique","Titi","Technicien",19854.23), 
};

foreach(Salarie s in salaries)
{
    Console.WriteLine(s);
    if(s.Matricule == "003")
    {
        Console.WriteLine("Je vien de trouver le salrie 003 !!!!");
    }
}