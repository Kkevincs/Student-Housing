using API.API.BLL.Services;
using API.API.DAL.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Repository.Models
{
    public class Location
    {
        public Location()
        {
        }

        public Location(string line)
        {
            var fields = line.Split(",");
            Id = Convert.ToInt32(fields[0]);
            County = "Netherlands";
            City = fields[1];
            var address = fields[2].Split(" ");
            Street = string.Join(" ", address.Take(address.Length - 1));
            HouseNumber = Convert.ToInt32(address[address.Count() - 1]);
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string County { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int? PostCode { get; set; } = null;
        public int HouseNumber { get; set; }
        public House HouseNav { get; set; }
        public ICollection<Bill> BillsNav { get; set; }



    }
}
