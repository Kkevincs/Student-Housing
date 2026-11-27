using System.Globalization;

namespace API.API.BLL.DTOs
{
    public class CreateEmployeeDto
    {



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
