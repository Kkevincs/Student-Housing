using API.Repository.Models;
using System.Runtime.CompilerServices;

namespace API.API.BLL.Services
{

    public class AddPropertysFromCsv
    {

        private readonly LocationService _locationService;
        private readonly HouseService _houseService;

        public AddPropertysFromCsv(LocationService locationService, HouseService houseService)
        {
            _locationService = locationService;
            _houseService = houseService;
        }

        public async Task LoadCsv(string filename)
        {
            foreach (var item in File.ReadAllLines(filename).Skip(1))
            {
                await _locationService.CreateWithId(new Location(item));
                await _houseService.CreateWithId(new House(item));
            }
        }
    }
}
