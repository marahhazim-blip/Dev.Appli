using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoAPIs.Repository.Entities
{
    // Pour fixer manuellement le nom de la table qui va être générée par EF Core, on peut utiliser l'annotation Table telle que:
    [Table("dog")]
    public class Dog
    {
        // Si l'on utilise un nom de clé primaire différent de 'Id' ou 'NomClasseId', on doit lui spécifier qu'il s'agit de la clé primaire via:
        [Key]

        // Pour choisir manuellement le nom des collonnes générées par la suite, on peut utiliser l'annotation Column telle que:
        [Column("dog_id")]
        
        public int DogId { get; set; }
        // public int Blabla { get; set; }

        // Pour fixer la taille maximale de la colonne de type textuelle, on va utiliser la propriété 'MaxLength'
        [MaxLength(50)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string Breed { get; set; }


        public DateOnly? BirthDay { get; set; }
        
        
        public DogColor Color { get; set; }

    }

    public enum DogColor
    {
        Fire,
        Beige,
        Orange
    }
}
