namespace API.API.BLL.DTOs
{
    public class GetBillDto
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int GasBill { get; set; }
        public int ElectricityBill { get; set; }
    }
}
