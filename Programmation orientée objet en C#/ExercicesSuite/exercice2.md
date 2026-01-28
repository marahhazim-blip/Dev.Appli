# Exercice 2

Créer une application console C# qui gère des **commandes** et maintient des **statistiques globales** via `static`.

---

### Classe `Order`

**Caractéristiques (instance) :**

- `CustomerName` (string)
- `Amount` (decimal)
- `IsCancelled` (bool)

**Caractéristiques (static) :**

- `CreatedOrdersCount` (int) : nombre total de commandes créées
- `CancelledOrdersCount` (int) : nombre total de commandes annulées
- `TotalAmountCreated` (decimal) : somme des montants de toutes les commandes créées

**Comportement :**

- À la création d’une commande (Order):

  - incrémente `CreatedOrdersCount`
  - ajoute `Amount` à `TotalAmountCreated`

- Méthode `Cancel()` :

  - annule la commande une seule fois
  - incrémente `CancelledOrdersCount` une seule fois

## BONUS

### Classe `OrderUtils` (classe `static`)

**Méthodes :**

- `string NormalizeCustomerName(string name)` : trim + met la première lettre en majuscule, le reste en minuscules
- `bool IsValidCustomerName(string name)` : `true` si non vide et longueur >= 2
