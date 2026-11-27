using API.Repository.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;

namespace API.API.BLL.Services
{
    public class AddRoomsAndStudentsFromCsv
    {
        private readonly RoomService _roomService;
        private readonly StudentService _studentService;

        public AddRoomsAndStudentsFromCsv(RoomService roomService, StudentService studentService)
        {
            _roomService = roomService;
            _studentService = studentService;
        }

        public async Task Create(string filename)
        {
            using (StreamWriter writer = new StreamWriter("Student-Password.csv"))
            {
                writer.WriteLine("Email,Password");

                foreach (var item in File.ReadAllLines(filename).Skip(1))
                {
                    var fields = item.Split(',');

                    if (!string.IsNullOrWhiteSpace(fields[2]))
                    {
                        Student student = new Student(item);

                        string password = RandomNumberGenerator.GetString(
                            "abcdefghijkmnpqrstuvwxyzABCDEFGHJKLMNPQRSTUVWXYZ23456789",
                            10
                        );

                        student.PasswordHash = new PasswordHasher<Student>()
                            .HashPassword(student, password);

                        await _studentService.CreateWithId(student);

                        writer.WriteLine($"{student.Email},{password}");
                    }

                    await _roomService.CreateWithId(new Room(item));
                }
            }
        }
    }
}
