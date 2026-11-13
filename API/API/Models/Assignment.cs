using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Assignment
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int ChoreId { get; set; }
        public int StudentId { get; set; }
        public Chore ChoreNav { get; set; }
        public Student StudentNav { get; set; }
        public bool Done { get; set; }
    }
}
