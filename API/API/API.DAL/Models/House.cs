using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Repository.Models
{
    public class House
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LocationId { get; set; }
 
        public int TotalSquareMeter { get; set; }
        public ICollection<Room> RoomsNav { get; set; }
        public Location LocationNav { get; set; }
    }
}
