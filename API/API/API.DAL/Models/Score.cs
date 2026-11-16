using System.ComponentModel.DataAnnotations.Schema;

namespace API.Repository.Models
{
    public class Score
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Amount { get; set; }
        public Student StudentNav { get; set; }
        public int StudentId { get; set; }
    }
}
