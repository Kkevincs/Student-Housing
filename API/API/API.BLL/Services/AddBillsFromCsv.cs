namespace API.API.BLL.Services
{
    public class AddBillsFromCsv
    {
        private readonly BillService _service;

        public AddBillsFromCsv(BillService service)
        {
            _service = service;
        }

        public async Task Create(string filename) {
            foreach (var item in File.ReadAllLines(filename).Skip(1))
            {
               await _service.Create(new DTOs.CreateBillDto(item));
            }
        }
    }
}
