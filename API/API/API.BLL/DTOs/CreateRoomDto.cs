namespace API.API.BLL.DTOs
{
    public class CreateRoomDto
    {
        public int HouseId { get; set; }

        public float Price { get; set; }
        public int SquareMeter { get; set; }
        public int Roomnumber { get; set; }
        public bool Available { get; set; }
        public int? StudentId { get; set; }
    }
}
