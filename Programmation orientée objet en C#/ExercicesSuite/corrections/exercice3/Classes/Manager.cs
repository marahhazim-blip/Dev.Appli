namespace ExercicesPOO.Classes;

public class Manager : Employee
{
    public int TeamSize { get; set; }
    public decimal BonusPerPerson { get; set; }

    public Manager(
        string name,
        decimal baseSalary,
        int teamSize,
        decimal bonusPerPerson
    ) : base(name, baseSalary)
    {
        TeamSize = teamSize;
        BonusPerPerson = bonusPerPerson;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + (BonusPerPerson * TeamSize);
    }

    public override string Describe()
    {
        return $"{Name} - Manager - Team size: {TeamSize}";
    }
}