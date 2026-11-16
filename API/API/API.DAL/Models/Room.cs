using System.ComponentModel.DataAnnotations.Schema;

namespace API.Repository.Models
{
    public class Room
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int HouseId { get; set; }
        public House HouseNav { get; set; }
        public float Price { get; set; }
        public int SquareMeter { get; set; }
        public int Roomnumber { get; set; }
        public bool Available { get; set; }
        public Student StudentNav { get; set; }
        public int StudentId { get; set; }
    }
}
