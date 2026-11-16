namespace API.API.BLL.DTOs
{
    public class CreateAssignmentDto
    {
        public int ChoreId { get; set; }
        public int StudentId { get; set; }
        public bool Done { get; set; }
    }
}
