namespace API.API.BLL.DTOs
{
    public class CreateChoreDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int HowOften { get; set; }
        public int Point { get; set; }
        public int? StudentId { get; set; }
    }
}
