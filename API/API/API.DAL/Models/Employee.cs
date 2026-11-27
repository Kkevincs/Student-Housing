using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace API.API.DAL.Models
{
    public class Employee
    {
        public Employee()
        {
        }

        public Employee(string line)
        {
            var fields = line.Split(',');
            Id = int.Parse(fields[0]);
            Name = fields[1].Trim();
            SurName = fields[2].Trim();
            Email = fields[3].Trim();
            MonthlySalary = Convert.ToInt32(fields[4].Trim());
            JobTitle = fields[5].Trim();

            StartDate = DateTime.ParseExact(
                fields[6].Trim(),
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture);

            Location = fields[7].Trim();
            Manager = fields[8].Trim();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
