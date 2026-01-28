## Exercice 3

Créer une application console C# avec une hiérarchie de classes représentant des **employés**.

---

### Classe de base `Employee`

**Caractéristiques :**

- `Name` (string)
- `BaseSalary` (decimal)

**Méthodes :**

- `CalculateSalary()` : retourne le salaire (virtuel)
- `Describe()` : retourne une description textuelle (virtuel)

---

### Classe dérivée `Developer` (hérite de `Employee`)

**Caractéristiques :**

- `ProgrammingLanguage` (string)
- `BonusPerProject` (decimal)
- `ProjectsCompleted` (int)

**Méthodes :**

- Redéfinir `CalculateSalary()` :

  - salaire = salaire de base + bonus × projets

- Redéfinir `Describe()`

---

### Classe dérivée `Manager` (hérite de `Employee`)

**Caractéristiques :**

- `TeamSize` (int)
- `BonusPerPerson` (decimal)

**Méthodes :**

- Redéfinir `CalculateSalary()` :

  - salaire = salaire de base + bonus × taille d’équipe

- Redéfinir `Describe()`
