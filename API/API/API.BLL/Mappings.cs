using API.API.BLL.DTOs;
using API.API.DAL.Models;
using API.Repository.Models;
using AutoMapper;


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

            CreateMap<CreateHouseDto, House>();
            CreateMap<House, CreateHouseDto>();
            CreateMap<GetHouseDto, House>();
            CreateMap<House, GetHouseDto>();

            CreateMap<CreateLocationDto, Location>();
            CreateMap<Location, CreateLocationDto>();
            CreateMap<GetLocationDto, Location>();
            CreateMap<Location,  GetLocationDto>();

            CreateMap<CreateRoomDto, Room>();
            CreateMap<Room, CreateRoomDto>();
            CreateMap<GetRoomDto, Room>();
            CreateMap<Room, GetRoomDto>();

            CreateMap<CreateScoreDto, Score>();
            CreateMap<Score, CreateScoreDto>();
            CreateMap<GetScoreDto, Score>();
            CreateMap<Score, GetScoreDto>();

            CreateMap<CreateStudentDto, Student>();
            CreateMap<Student, CreateStudentDto>();
            CreateMap<GetStudentDto, Student>();
            CreateMap<Student, GetStudentDto>();

            CreateMap<CreateEmployeeDto, Employee>();
            CreateMap<Employee, CreateEmployeeDto>();
            CreateMap<GetEmployeeDto, Employee>();
            CreateMap<Employee, GetEmployeeDto>();

            CreateMap<GetBillDto, Bill>();
            CreateMap<Bill, GetBillDto>();
            CreateMap<CreateBillDto, Bill>();
            CreateMap<Bill, CreateBillDto>();

            CreateMap<RegisterOwnerDto, Owner>();


        }

    }
}
