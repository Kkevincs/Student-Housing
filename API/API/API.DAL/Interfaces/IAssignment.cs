using API.Repository.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Repository.Interfaces
{
    public interface IAssignment
    {
        public Task Create(Assignment assignment);
        public Task Delete(Assignment assignment);
        public Task Update(Assignment assignment);
        public Task<List<Assignment>> GetAll();
        public Task<Assignment> GetById(int id);
            
        
    }
}
