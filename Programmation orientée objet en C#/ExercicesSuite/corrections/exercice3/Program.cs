
using ExercicesPOO.Classes;

Console.WriteLine("Exercice 3");

Employee employee = new Employee("Alex", 2000m);

Developer developer = new Developer("Toto", 2500, "C#", 300m, 3 );

Manager manager = new Manager("Tata", 3000, 5, 200m );

List<Employee> employees = new List<Employee>
{
    employee,
    developer,
    manager
};

foreach (var e in employees)
{
    Console.WriteLine(e.Describe());
    Console.WriteLine($"Salaire: {e.CalculateSalary()} euros");
    Console.WriteLine();
}
