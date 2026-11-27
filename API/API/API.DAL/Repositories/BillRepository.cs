using API.API.DAL.Interfaces;
using API.API.DAL.Models;
using API.Repository;
using Microsoft.EntityFrameworkCore;

namespace API.API.DAL.Repositories
{
    public class BillRepository : IBill
    {
        private readonly HousingDbContext _context;

        public BillRepository(HousingDbContext context)
        {
            _context = context;
        }

        public async Task Create(Bill bill)
        {
            _context.Bills.Add(bill);
            await _context.SaveChangesAsync();
        }
    }
}
