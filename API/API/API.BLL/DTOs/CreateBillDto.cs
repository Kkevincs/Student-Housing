namespace API.API.BLL.DTOs
{
    public class CreateBillDto
    {
        public CreateBillDto()
        {
        }

        public CreateBillDto(string line)
        {
            var fields = line.Split(",");
            LocationId = Convert.ToInt32(fields[0]);
            Year = Convert.ToInt32(fields[1]);
            Month = Convert.ToInt32(fields[2]);
            GasBill = Convert.ToInt32(fields[3]);
            ElectricityBill = Convert.ToInt32(fields[4]);
        }

        public int LocationId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int GasBill { get; set; }
        public int ElectricityBill { get; set; }
    }
}
