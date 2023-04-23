using System.ComponentModel.DataAnnotations;

namespace LabToys.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
