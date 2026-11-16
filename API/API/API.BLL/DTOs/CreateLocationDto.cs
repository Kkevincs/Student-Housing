namespace API.API.BLL.DTOs
{
    public class CreateLocationDto
    {
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostCode { get; set; }
        public int HouseNumber { get; set; }
    }
}
