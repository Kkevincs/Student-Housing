namespace API.API.BLL.DTOs
{
    public class GetAssigmentDto
    {
        public int Id { get; set; }
        public int ChoreId { get; set; }
        public int StudentId { get; set; }
        public bool Done { get; set; }
    }
}
