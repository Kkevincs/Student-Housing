using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace API.Models
{
    public class Student
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; } 
        public DateTime DateOfBirth { get; set; }
        public string Nationality { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Assignment> Assignments { get; set; }
        public Room RoomNav { get; set; }

        public Score ScoreNav { get; set; }

    }
}
