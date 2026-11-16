using API.API.BLL.DTOs;
using API.Repository.Models;
using AutoMapper


namespace API.API.BLL

{
    public class Mappings : Profile
    {
        public Mappings()
        {
            CreateMap<CreateChoreDto, Chore>();
            CreateMap<Chore, CreateChoreDto>();
            CreateMap<GetChoreDto, Chore>();
            CreateMap<Chore, GetChoreDto>();

            CreateMap<CreateAssignmentDto, Assignment>();
            CreateMap<Assignment, CreateAssignmentDto>();
            CreateMap<GetAssigmentDto, Assignment>();
            CreateMap<Assignment, GetAssigmentDto>();
            //todo


        }

    }
}
