namespace ExercicesPOO.Classes;

public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }
    public decimal BonusPerProject { get; set; }
    public int ProjectsCompleted { get; set; }

    public Developer(
        string name,
        decimal baseSalary,
        string programmingLanguage,
        decimal bonusPerProject,
        int projectsCompleted
    ) : base(name, baseSalary)
    {
        ProgrammingLanguage = programmingLanguage;
        BonusPerProject = bonusPerProject;
        ProjectsCompleted = projectsCompleted;
    }

    public override decimal CalculateSalary()
    {
        return BaseSalary + (BonusPerProject * ProjectsCompleted);
    }

    public override string Describe()
    {
        return $"{Name} - Developer ({ProgrammingLanguage}) - Projects: {ProjectsCompleted}";
    }
}