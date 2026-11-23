using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace API.Repository.Models
{
    public class Student
    {
        public Student()
        {
        }

        public Student(string line)
        {
            var fields = line.Split(',');
            Id = Convert.ToInt32(fields[2]);
            StartYear = Convert.ToInt32(fields[3]);
            EndYear = Convert.ToInt32(fields[4]);
            FirstName = fields[5];
            LastName = fields[6];
            Email = fields[7];
            PhoneNumber = fields[8];
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime? DateOfBirth { get; set; }
        public string? Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public int StartYear { get; set; }
        public int EndYear { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public Room RoomNav { get; set; }

        public Score ScoreNav { get; set; }

    }
}
