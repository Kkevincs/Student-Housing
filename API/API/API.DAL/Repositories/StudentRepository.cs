using API


using API.Repository;
using API.Repository.Interfaces;
using API.Repository.Models;
using Microsoft.EntityFrameworkCore;

namespace API.API.DAL.Repositories
{
    public class StudentRepository : IStudent
    {
        private readonly HousingDbContext _housingDbContext;

        public StudentRepository(HousingDbContext housingDbContext)
        {
            _housingDbContext = housingDbContext;
        }

        public async Task Create(Student student)
        {
            _housingDbContext.Students.Add(student);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task Delete(Student student)
        {
            _housingDbContext.Students.Remove(student);
            await _housingDbContext.SaveChangesAsync();
        }

        public async Task<List<Student>> GetAll()
        {
            return await _housingDbContext.Students.ToListAsync();
        }

        public async Task<Student> GetById(int id)
        {
            return await _housingDbContext.Students.FindAsync(id);
        }

        public async Task Update(Student student)
        {
            _housingDbContext.Students.Update(student);
            await _housingDbContext.SaveChangesAsync();
        }
    }
}
