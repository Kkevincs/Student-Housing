using API.API.DAL.Models;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Repository.Models
{
    public class House
    {
        public House()
        {
        }

        public House(string line)
        {
            var fields = line.Split(",");
            LocationId = Convert.ToInt32(fields[0]);
            RoomsAvailable = Convert.ToInt32(fields[3]);
            TotalSquareMeter = Convert.ToInt32(fields[4]);
            PricePerRoom = Convert.ToInt32(fields[5]);
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int RoomsAvailable { get; set; }
 
        public int TotalSquareMeter { get; set; }

        public int PricePerRoom { get; set; }
        public ICollection<Room> RoomsNav { get; set; }
    }
}
