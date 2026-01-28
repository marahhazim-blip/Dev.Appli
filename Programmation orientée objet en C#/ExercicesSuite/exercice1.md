# Exercice 1

Créer une application console C# avec 3 classes : `Animal`, `Enclos`, `VetoReport`.

### Classe `Animal`

**Caractéristiques :**

- `Name` (string)
- `Species` (string)
- `Energy` (int, 0..100)

**Méthodes :**

- `Eat(int amount)` : augmente `Energy` (max 100)
- `Play(int amount)` : diminue `Energy` (min 0)
- `Describe()` : retourne une string descriptive

---

### Classe `Enclos`

**Caractéristiques :**

- `Name` (string)
- `Capacity` (int) avec validation : `>= 1`
- Contient une liste d'`Animal`

**Méthodes :**

- `AddAnimal(Animal animal)` : ajoute si place disponible
- `RemoveAnimal(string name)` : retire un animal par nom, retourne `true/false`
- `GetAnimals()` : retourne une copie de la liste
- `PrintStatus()` : affiche l’état de l’enclos

---

### Classe `VetoReport`

**Caractéristiques (champs privés) :**

- `animalName` (string)
- `notes` (string)
- `severity` (int, 1..5)

**Méthodes :**

- `SetAnimalName(string)` / `GetAnimalName()`
- `SetNotes(string)` / `GetNotes()`
- `SetSeverity(int)` / `GetSeverity()` (valide 1..5)
- `Print()` : affiche le rapport

---

### Programme principal (`Program.cs`)

- Créer un `Enclos` `"Enclos Nord"` de capacité 2
- Créer 3 animaux : `Luna` (Chat, 80), `Rex` (Chien, 50), `Milo` (Lapin, 30)
- Ajouter 2 animaux, puis tenter d’ajouter le 3e (doit échouer proprement)
- Appeler : `Luna.Play(40)` et `Rex.Eat(60)`
- Afficher l’état de l’enclos
- Créer 2 rapports vétérinaires et les afficher :

  - Luna : “Fatigue après jeu”, sévérité 2
  - Rex : “Très bonne forme”, sévérité 1

- Tester une sévérité invalide (ex. 7) et vérifier le comportement
