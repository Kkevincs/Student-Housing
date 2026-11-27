using System.ComponentModel.DataAnnotations.Schema;

namespace API.Repository.Models
{
    public class Room
    {
        public Room()
        {
        }

        public Room(string line)
        {
            var fields = line.Split(",");
            Roomnumber = Convert.ToInt32(fields[1]);
            HouseId = Convert.ToInt32(fields[0]);

            if (!string.IsNullOrWhiteSpace(fields[2]))
            {
                StudentId = Convert.ToInt32(fields[2]);
                Available = false;
            }
            else {
                Available = true;
            }


        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int HouseId { get; set; }

        public int? SquareMeter { get; set; }
        public int? Roomnumber { get; set; }
        public bool Available { get; set; }
        public int? StudentId { get; set; } = null;
        public Student StudentNav { get; set; }
        public House HouseNav { get; set; }

    }
}
