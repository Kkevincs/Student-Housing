namespace API.API.BLL.DTOs
{
    public class GetLocationDto
    {
        public int Id { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostCode { get; set; }
        public int HouseNumber { get; set; }
    }
}
