using System.ComponentModel.DataAnnotations.Schema;

namespace API.API.DAL.Models
{
    public class Employee
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Email { get; set; }
        public int MonthlySalary { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public string Location { get; set; }
        public string Manager { get; set; }
    }
}
