namespace ExercicesPOO.Classes;

public class Employee
{
    public string Name { get; set; }
    public decimal BaseSalary { get; set; }

    public Employee(string name, decimal baseSalary)
    {
        Name = name;
        BaseSalary = baseSalary;
    }

    public virtual decimal CalculateSalary()
    {
        return BaseSalary;
    }

    public virtual string Describe()
    {
        return $"{Name} - Employee - salaire de base: {BaseSalary} euros.";
    }
}