using System.ComponentModel.DataAnnotations.Schema;

namespace API.Models
{
    public class Location
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int PostCode { get; set; }
        public int HouseNumber { get; set; }
        public House HouseNav { get; set; }


    }
}
