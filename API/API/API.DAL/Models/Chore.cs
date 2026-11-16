using System.ComponentModel.DataAnnotations.Schema;

namespace API.Repository.Models
{
    public class Chore
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int HowOften { get; set; }
        public int Point { get; set; }
        public ICollection<Assignment> Assignments { get; set; }

    }
}
