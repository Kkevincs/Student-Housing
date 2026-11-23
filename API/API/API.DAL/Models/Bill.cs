using API.Repository.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.API.DAL.Models
{
    public class Bill
    {
        public Bill()
        {
        }

        public Bill(string line)
        {
            var fields = line.Split(";");

            LocationId = Convert.ToInt32(fields[0]);
            Year = Convert.ToInt32(fields[1]);
            Month = Convert.ToInt32(fields[2]);
            GasBill = Convert.ToInt32(fields[3]);
            ElectricityBill = Convert.ToInt32(fields[4]);
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int GasBill { get; set; }
        public int ElectricityBill { get; set; }

        public Location LocationNav { get; set; }
    }
}
